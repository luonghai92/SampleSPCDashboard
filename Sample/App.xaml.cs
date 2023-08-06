using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Sample.Controls;
using Sample.Controls.ViewModel;
using Sample.ViewModel;

namespace Sample
{
    
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainViewModel>();
            services.AddTransient<Station>(); 

            _serviceProvider = services.BuildServiceProvider();

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
