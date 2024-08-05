using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using TrainStationTestApp.Data;
using TrainStationTestApp.ViewModels;

namespace TrainStationTestApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IHost? AppHost { get; private set; }
    public App() {
        AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) => {
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainWindow>();
            services.AddTransient<ILinesRepository, LinesRepository>();
        }).Build();
    }

    protected override async void OnStartup(StartupEventArgs e) {
        
        await AppHost!.StartAsync();
        
        var startUpWindow = AppHost.Services.GetRequiredService<MainWindow>();
        startUpWindow.Show();
       
        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e) {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}
