using System.Globalization;
using System.Threading;
using System.Windows;

namespace KeMBody
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
        }
    }
}
