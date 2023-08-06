using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.DependencyInjection;

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMyService _myService;
        public MainWindow(IMyService myService)
        {
            InitializeComponent();
            var car = new Car();
            car.Beep();

            Horn1 horn1 = new Horn1(10);
            var car1 = new Car1(horn1); // horn inject vào car
            car1.Beep();

            Car2 car2 = new Car2(new HeavyHorn());
            car2.Beep();                             // (kểu to lắm) BEEP BEEP BEEP ...

            Car2 car3 = new Car2(new LightHorn());
            car3.Beep();
            _myService = myService;
            _myService.DoSomething();
        }

    }
    public class Horn
    {
        public void Beep() => Console.WriteLine("Beep - beep - beep ...");
    }

    public class Car
    {
        public void Beep()
        {
            // chức năng Beep xây dựng có định với Horn
            // tự tạo đối tượng horn (new) và dùng nó
            Horn horn = new Horn();
            horn.Beep();
        }
    }

    public class Horn1
    {
        int level;
        public Horn1(int level) => this.level = level; // thêm khởi tạo level
        public void Beep() => Console.WriteLine("Beep - beep - beep ...");
    }
    public class Car1
    {
        // horn là một Dependecy của Car
        Horn1 horn1;

        // dependency Horn được đưa vào Car qua hàm khởi tạo
        public Car1(Horn1 horn1) => this.horn1 = horn1;

        public void Beep()
        {
            // Sử dụng Dependecy đã được Inject
            horn1.Beep();
        }
    }
    public interface IHorn2
    {
        void Beep();
    }
    public class Car2
    {
        IHorn2 horn;                                  // IHorn (Interface) là một Dependecy của Car
        public Car2(IHorn2 horn) => this.horn = horn; // Inject từ hàm  tạo
        public void Beep() => horn.Beep();
    }
    public class HeavyHorn : IHorn2
    {
        public void Beep() => Console.WriteLine("(kêu to lắm) BEEP BEEP BEEP ...");
    }

    public class LightHorn : IHorn2
    {
        public void Beep() => Console.WriteLine("(kêu bé lắm) beep  bep  bep ...");
    }
}
