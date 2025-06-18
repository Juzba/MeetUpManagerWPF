using MeetUpManagerWPF.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MeetUpManagerWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; } = default!;

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>();
            services.AddSingleton<MainWindow>();

            ServiceProvider = services.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            
        }

    }

}
