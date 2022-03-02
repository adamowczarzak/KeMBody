using KeMBody.ViewModels;
using System;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace KeMBody
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");

            DataContext = new MainWindowViewModel(() => Close());
            InitializeComponent();
        }
    }
}
