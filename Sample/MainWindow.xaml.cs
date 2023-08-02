using Sample.Controls;
using Sample.DAL;
using Sample.ViewModel;
using System;
using System.Windows;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainViewModel vm = new MainViewModel();
        Database db = null;
        XBar xBar01 = new XBar();
        XBar xBar02 = new XBar();
        public MainWindow()
        {
            InitializeComponent();
            db = new Database();
            this.DataContext = vm;
            xBar01 = winFormsHost1.Child as XBar;
            xBar01.data = db.getSPCData();
            xBar01.histogramData = db.getHistogramData();

            xBar02 = winFormsHost2.Child as XBar;
            xBar02.data = db.getSPCData();
            xBar02.histogramData = db.getHistogramData();
        }

        private void createTestData(object sender, RoutedEventArgs e)
        {
            Random n = new Random();
            DateTime now = DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                string querry = $"INSERT INTO data(time_get, qty) VALUES('{now.AddMinutes(i * 5).ToString("yyyy-MM-dd HH:mm:ss")}','{n.Next(50, 75)}')";

            }
        }

        private void acs(object sender, RoutedEventArgs e)
        {

        }
    }
}
