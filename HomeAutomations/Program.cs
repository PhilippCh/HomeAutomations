using System.Reflection;
using HomeAutomations.Extensions;
using HomeAutomations.Vault;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.Runtime;

#pragma warning disable CA1812

try
{
	var assembly = Assembly.GetExecutingAssembly();

    await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonMqttEntityManagement()
        .UseNetDaemonTextToSpeech()
        /*.ConfigureAppConfiguration(
	        config =>
	        {
		        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
		        config.AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true);
		        config.AddEnvironmentVariables(prefix: "VAULT_");

		        var builtConfig = config.Build();

		        if (builtConfig.GetSection("Vault")["Role"] != null)
		        {
			        config.AddVault(options =>
			        {
				        var vaultOptions = builtConfig.GetSection("Vault");
				        options.Address = vaultOptions["Address"];
				        options.Role = vaultOptions["Role"];
				        options.MountPath = vaultOptions["MountPath"];
				        options.SecretType = vaultOptions["SecretType"];
				        options.Secret = builtConfig.GetSection("VAULT_SECRET_ID").Value;
			        });
		        }
	        })*/
        .ConfigureServices((context, services) =>
            services
                .AddAppsFromAssembly(assembly)
                .AddNetDaemonStateManager()
                .AddNetDaemonScheduler()
                .AddAutomationServices(assembly, context.Configuration)
        )
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}
