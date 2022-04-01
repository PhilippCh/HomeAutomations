using HomeAutomations.Client.Commands;
using HomeAutomations.Client.Media;
using HomeAutomations.Client.Services.Media;
using HomeAutomations.Client.TrayIcon;
using HomeAutomations.Client.Util;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Client;

public class Startup
{
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
            .AddOpenApiDocument()

            // Config
            .Configure<MqttConfig>(_config.GetSection("MQTT"))
            .Configure<MediaStatusConfig>(_config.GetSection("MediaStatus"))

            // Services
            .AddSingleton<CommandParser>()
            .AddSingleton<MediaControllerService>()
            .AddSingleton<NowPlayingMediaSessionManager>()
            .AddSingleton<MqttService>()
            .AddSingleton(trayIconService)

            // Background services
            .AddHostedService<MediaStatusBackgroundService>()

            .AddControllers()
            .AddControllersAsServices();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseOpenApi();
        app.UseSwaggerUi3();
        //app.UseSwaggerUI(
//            c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Moonlight Remote Client REST API"));

        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
