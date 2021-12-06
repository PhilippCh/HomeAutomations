using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive.Linq;
using HomeAssistant.Automations.Extensions;
using HomeAssistantGenerated;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;
using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Apps
{
    [NetDaemonApp]
    public class MoonlightGameLauncher
    {
        private readonly IHaContext _haContext;
        private readonly Entities _entities;
        private readonly HttpClient _client = new HttpClient();
        private readonly IReadOnlyDictionary<string, Func<VarEntity?>> _availableGameOptionsFactories;

        public MoonlightGameLauncher(IHaContext haContext)
        {
            _haContext = haContext;
            _entities = new Entities(_haContext);

            CreateListeners();

            _availableGameOptionsFactories = new Dictionary<string, Func<VarEntity?>>
            {
                { "", () => null },
                { "Desktop Pups", () => _entities.Var.MoonlightAvailableGamesDesktopPhilipp },
                { "Desktop Fups", () => _entities.Var.MoonlightAvailableGamesDesktopFabienne }
            };
        }

        private void CreateListeners()
        {
            _entities.InputSelect.MoonlightSelectedHost.StateChanges()
                .Subscribe(s => UpdateGameInputSelect(s.New?.State));
            _entities.Var.MoonlightIsRunning.StateChanges()
                .Where(s => s.New?.AsBoolean() == true)
                .Subscribe(_ => StartStream());
        }

        private void UpdateGameInputSelect(string? newState)
        {
            var availableGamesEntity = _availableGameOptionsFactories[newState ?? string.Empty]();
            var availableGames = availableGamesEntity?.State?.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            if (availableGames == null)
            {
                return;
            }

            _entities.InputSelect.MoonlightSelectedGame.CallService("set_options", new
            {
                options = availableGames
            });
        }

        private async void StartStream()
        {
            var request = new
            {
                Host = _entities.InputSelect.MoonlightSelectedHost.State,
                Game = _entities.InputSelect.MoonlightSelectedGame.State
            };
            var response = await _client.PostAsJsonAsync("https://moonlight-remote.pupslab.de/api/start", request);

            if (!response.IsSuccessStatusCode)
            {
                _entities.Var.MoonlightIsRunning.CallService("set", new { value = false });
            }
        }
    }
}