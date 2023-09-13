using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Aline.API.Helpers;
using Microsoft.Extensions.Options;

namespace Aline.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(
                    (hostingContext, config) =>
                    {
                        config.AddJsonFile($"appsettings.{EnviromentHelper.GetEnviroment()}.json");
                    }
                )
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureLogging((context, logging) =>
                {
                    logging.AddEventLog(options =>
                    {
                        context.Configuration.GetSection("Logging").GetSection("LoggingProvider").GetSection("LoggerFileOptions").Bind(options);
                    });
                });
    }
}