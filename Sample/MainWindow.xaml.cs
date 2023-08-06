using Sample.Controls;
using Sample.DAL;
using Sample.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI.Wpf;
using ReactiveUI;
using System.Reactive.Disposables;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewFor<MainViewModel>
    {
        Database db = null;
        XBar xBar01 = new XBar();
        XBar xBar02 = new XBar();
        private MainViewModel _viewModel;
        public MainViewModel ViewModel {
            get =>  _viewModel; 
            set => _viewModel = value;
        }
        object IViewFor.ViewModel {
            get => ViewModel;
            set => ViewModel = (MainViewModel)value;
        }

        public MainWindow()
        {
            InitializeComponent();
            db = new Database();
            ViewModel = new MainViewModel();
            this.WhenActivated(d =>
            {
                this.WhenAnyValue(x => x.ViewModel).Subscribe(x =>
                {
                    this.DataContext = x;
                }).DisposeWith(d);
            });

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

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            main_panel.Visibility = Visibility.Visible;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            main_panel.Visibility = Visibility.Hidden;
        }

        private void ListViewItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}
