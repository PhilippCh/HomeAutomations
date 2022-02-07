﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive.Linq;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Extensions;
using HomeAssistant.Automations.Models;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;

namespace HomeAssistant.Automations.Apps.Moonlight
{
	[NetDaemonApp]
	public class MoonlightGameLauncher : BaseAutomation<MoonlightGameLauncher, MoonlightConfig>
	{
		private readonly Entities _entities;
		private readonly HttpClient _client = new();
		private readonly IReadOnlyDictionary<string, Func<VarEntity?>> _availableGameOptionsFactories;

		public MoonlightGameLauncher(BaseAutomationDependencyAggregate<MoonlightGameLauncher, MoonlightConfig> aggregate)
			: base(aggregate)
		{
			_entities = new Entities(Context);
			_availableGameOptionsFactories = new Dictionary<string, Func<VarEntity?>>
			{
				{ "", () => null },
				{ "Desktop Pups", () => _entities.Var.MoonlightAvailableGamesDesktopPhilipp },
				{ "Desktop Fups", () => _entities.Var.MoonlightAvailableGamesDesktopFabienne }
			};
		}

		protected override void Start()
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

			_entities.InputSelect.MoonlightSelectedGame.CallService(
				"set_options", new
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