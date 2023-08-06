using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow mainWindow = null;
        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<IMyService, MyService>();
            //services.AddSingleton<IMyService, HaiService>();
            var serviceProvider = services.BuildServiceProvider();
            
            mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            //IMyService service = new MyService();
            //mainWindow = new MainWindow(service);
            mainWindow.Show();
        }
    }
    public interface IMyService
    {
        void DoSomething();
    }

    public class MyService : IMyService
    {
        public void DoSomething()
        {
            MessageBox.Show("Yes I do");
        }

        public void DoSomething2()
        {
            throw new NotImplementedException();
        }
    }
    public class HaiService : IMyService
    {
        public void DoSomething()
        {
            MessageBox.Show("LUONG NHU HAI");
        }

        public void DoSomething2()
        {
            throw new NotImplementedException();
        }
    }
}
