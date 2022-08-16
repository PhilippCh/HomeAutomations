using HomeAutomations.Client.Commands;
using HomeAutomations.Client.Services;
using HomeAutomations.Client.Services.Media;
using HomeAutomations.Client.Services.Media.NowPlaying;
using HomeAutomations.Client.Services.Media.VideoLan;
using HomeAutomations.Client.Services.TrayIcon;
using HomeAutomations.Client.Util;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Client;

public class Startup
{
	private const string DocumentName = "HomeAutomations.Client REST API";

	private readonly IConfiguration _config;

	public Startup(IConfiguration config)
	{
		_config = config;
	}

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(options =>
        {
            options.EnableEndpointRouting = false;
            options.InputFormatters.Insert(0, new RawJsonBodyInputFormatter());
        });

        var trayIconService = new TrayIconService();

        services
            .AddOptions()
            .AddSwaggerGen()
            .AddOpenApiDocument(s => s.PostProcess = d => d.Info.Title = DocumentName)

            // Config
            .Configure<MediaStatusConfig>(_config.GetSection("MediaStatus"))
            .Configure<VlcConfig>(_config.GetSection("VLC"))

            // Services
            .AddTransient<HostService>()
            .AddSingleton<CommandParser>()
            .AddSingleton<MediaControllerService>()
            .AddSingleton<DisplayService>()
            .AddSingleton<NowPlayingMediaSessionManager>()
            .AddSingleton<VlcRemoteApiService>()
            .AddSingleton(trayIconService)
            .AddMqttService(_config)

            // Background services
            .AddHostedService<MediaStatusBackgroundService>()

            .AddControllers()
            .AddControllersAsServices();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
	    app.UseDeveloperExceptionPage();
        app.UseOpenApi(c => c.DocumentName = DocumentName);
        app.UseSwaggerUi3(c => c.DocumentTitle = DocumentName);

        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
