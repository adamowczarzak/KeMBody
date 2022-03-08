using System.ComponentModel;
using System.Windows.Input;
using KeMBody.Extensions;

namespace KeMBody.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand CloseWindowCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            CloseWindowCommand = new RelayCommand(CloseWindow);
        }

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CloseWindow(object source)
        {
            source.InvokeToMethod(Names.Close);
        }

    }
}
