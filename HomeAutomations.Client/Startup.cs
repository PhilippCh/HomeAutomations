using HomeAutomations.Client.Commands;
using HomeAutomations.Client.Media;
using HomeAutomations.Client.Util;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace HomeAutomations.Client;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(options =>
        {
            options.EnableEndpointRouting = false;
            options.InputFormatters.Insert(0, new RawJsonBodyInputFormatter());
        });

        services
            .AddOptions()
            .AddSwaggerGen()

            // Services
            .AddSingleton<CommandParser>()
            .AddSingleton<MediaControllerService>()

            .AddControllers()
            .AddControllersAsServices();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(
            c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Moonlight Remote Client REST API"));

        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}