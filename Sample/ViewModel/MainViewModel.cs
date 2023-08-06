using ReactiveUI;
using SimpleTCP;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Sample.ViewModel
{
    public class MainViewModel : ReactiveObject
    {
        static MainViewModel()
        {
            Splat.Locator.CurrentMutable.Register(() => new MainWindow(), typeof(IViewFor<MainViewModel>));
        }
        SimpleTcpServer server = null;
        public MainViewModel()
        {
            server = new SimpleTcpServer();
            server.DataReceived +=  Server_DataReceived;
            server.Start(1000);

        }
        private string _txtLb;

        public string txtLb
        {
            get { return _txtLb; }
            set { 
                this.RaiseAndSetIfChanged(ref _txtLb, value);
            }
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            

            txtLb = DateTime.Now.ToString();


        }
    }
}
