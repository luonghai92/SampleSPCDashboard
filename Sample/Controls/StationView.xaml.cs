using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using SimpleTCP;

namespace Sample.Controls
{
    /// <summary>
    /// Interaction logic for StationView.xaml
    /// </summary>
    public partial class StationView : UserControl, INotifyPropertyChanged
    {
        SimpleTcpServer server = null;
        Timer timer1 = new Timer();
        public StationView()
        {
            InitializeComponent();
            this.DataContext = this;
            timer1.Enabled = true;
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Interval = 1000;
            timer1.Start();
            server = new SimpleTcpServer();
            server.DataReceived += Server_DataReceived;
            server.Start(1000);
            this.DataContext = this;
        }

        private void Server_DataReceived(object sender, Message e)
        {
            
            
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                //abc.Content = progressValue++.ToString();
                progressValue++;
            }));
        }
        private double _progressValue;
        public double progressValue
        { 
            get { return _progressValue; }
            set {
                if (_progressValue != value)
                {
                    _progressValue = value;
                    RaisePropertyChanged(nameof(progressValue));
                }
            }
        }
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(StationView));

        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public string Text
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        private static void OnTextChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            if (d is StationView stationView)
            {
                //stationView.lbStationName.Content = e.NewValue;
            }
        }

        private void clickme(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
