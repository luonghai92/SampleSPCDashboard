using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Sample.Controls.ViewModel
{
    
    public class Station:ReactiveObject
    {
        Timer timer1 = new Timer();
        static Station()
        {
            Splat.Locator.CurrentMutable.Register(() => new StationView(), typeof(IViewFor<Station>));
        }
        public Station() {
            timer1.Enabled = true;
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Interval = 1000;
            timer1.Start();
        }
        int i;
        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            IdealProd++;
        }
        double _down_time;
        public double DownTime
        {
            get { return _down_time; }
            set { this.RaiseAndSetIfChanged(ref _down_time, value); }
        }
        string _mttr;
        public string MTTR
        {
            get { return _mttr; }
            set { this.RaiseAndSetIfChanged(ref _mttr, value); }
        }
        string _mtbf;
        public string MTBF
        {
            get { return _mtbf; }
            set { this.RaiseAndSetIfChanged(ref _mtbf, value); }
        }

        int _ideal_prod = 100;
        public int IdealProd
        {
            get { return _ideal_prod; }
            set
            {
                this.RaiseAndSetIfChanged(ref _ideal_prod, value);
            }
        }
        int _gross_prod;
        public int GrossProd
        {
            get { return _gross_prod; }
            set
            {
                this.RaiseAndSetIfChanged(ref _gross_prod, value);
            }
        }
        int _losses;
        public int Losses
        {
            get { return _losses; }
            set
            {
                this.RaiseAndSetIfChanged(ref _losses, value);
            }
        }
        int _total;
        public int Total
        {
            get { return _total; }
            set
            {
                this.RaiseAndSetIfChanged(ref _total, value);
            }
        }
        int _num_ok;
        public int NumOK
        {
            get { return _num_ok; }
            set
            {
                this.RaiseAndSetIfChanged(ref _num_ok, value);
            }
        }
        int _num_ng;
        public int NumNG
        {
            get { return _num_ng; }
            set
            {
                this.RaiseAndSetIfChanged(ref _num_ng, value);
            }
        }
        int _num_ng_setup;
        public int NumNGSetup
        {
            get { return _num_ng_setup;}
            set
            {
                this.RaiseAndSetIfChanged(ref _num_ng_setup, value);
            }
        }
        private double _time_spent_percent;
        public double TimeSpentPercent
        {
            get { return _time_spent_percent; }
            set
            {
                if (_time_spent_percent != value)
                {
                    _time_spent_percent = value;
                    this.RaiseAndSetIfChanged(ref _time_spent_percent, value);
                }
            }
        }

        private double _oee;
        public double Oee
        {
            get { return _oee; }
            set
            {
                this.RaiseAndSetIfChanged(ref _oee, value);
            }
        }

        private double _avaibility;
        public double Aavaibility
        {
            get { return _avaibility; }
            set
            {
                this.RaiseAndSetIfChanged(ref _avaibility, value);
            }
        }

        private double _performance;
        public double Performance
        {
            get { return _performance; }
            set
            {
                this.RaiseAndSetIfChanged(ref _performance, value);
            }
        }
        private double _quantity_percent;
        public double QuantityPercent
        {
            get { return _quantity_percent; }
            set
            {
                this.RaiseAndSetIfChanged(ref _quantity_percent, value);
            }
        }
        private double _quantity_ng_percent;
        public double QuantityNGPercent
        {
            get { return _quantity_ng_percent; }
            set
            {
                this.RaiseAndSetIfChanged(ref _quantity_ng_percent, value);
            }
        }
        private SolidBrush _status_color = new SolidBrush(Color.Gray);
        public SolidBrush StatusColor
        {
            get { return _status_color; }
            set
            {
                this.RaiseAndSetIfChanged(ref _status_color, value);
            }
        }

        private string _status_text;
        public string StatusText
        {
            get { return _status_text; }
            set
            {
                this.RaiseAndSetIfChanged(ref _status_text, value);
            }
        }
    }

}
