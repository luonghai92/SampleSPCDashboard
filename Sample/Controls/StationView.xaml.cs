using System;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Sample.Controls.ViewModel;
using SimpleTCP;

namespace Sample.Controls
{
    /// <summary>
    /// Interaction logic for StationView.xaml
    /// </summary>
    public partial class StationView : UserControl, IViewFor<Station>
    {
        
        private Station _ViewModel = new Station();
        public Station ViewModel
        {
            get => _ViewModel;
            set => _ViewModel = value;
        }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (Station)value;
        }
        public StationView()
        {
            InitializeComponent();
            
            
            this.WhenActivated(d =>
            {
                this.WhenAnyValue(x => x.ViewModel).Subscribe(x =>
                {
                    this.DataContext = x;
                }).DisposeWith(d);
            });

        }
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(StationView));
        public string Text
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        
        private void Server_DataReceived(object sender, Message e)
        {
            
            
        }
        
       
        
       
        

        
    }
}
