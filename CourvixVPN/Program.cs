using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using CourvixVPN.API;
using CourvixVPN.API.Interfaces;
using CourvixVPN.Shared;

namespace CourvixVPN
{
    internal static class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static async Task Main(string[] args)
        {
            ConfigureServices();
            
            // Get servers before app is started
            Globals.Servers = await Globals.Container.GetInstance<ICourvixApi>().GetServersAsync();
            
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        private static void ConfigureServices()
        {
            Globals.Container.RegisterSingleton<ICourvixApi, CourvixApi>();
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        private static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
    }
}