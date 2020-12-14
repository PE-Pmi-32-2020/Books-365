using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

using Books365.PL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost host;

        public App()
        {
            this.host = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                // Lets Create single tone instance of Master windows
                services.AddSingleton<Notifications>();
            }).ConfigureLogging(logBuilder =>
            {
                logBuilder.SetMinimumLevel(LogLevel.Information);
                logBuilder.AddNLog("nlog.config");

            }).Build();

            using (var serviceScope = this.host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var masterWindow = services.GetRequiredService<Notifications>();
                    masterWindow.Show();
                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured" + ex.Message);
                }
            }
        }
    }
}