using System.ComponentModel;
using System.Windows.Input;
using System;

namespace KeMBody.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand CloseWindowCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel(Action action)
        {
            CloseWindowCommand = new RelayCommand(action);
        }

        protected void OnPropertyChange(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
