using System.ComponentModel;
using System.Windows.Input;
using KeMBody.Enumerations;
using KeMBody.Extensions;

namespace KeMBody.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand CloseWindowCommand { get; private set; }
        public ICommand DisplayPageCommand { get; private set; }
        public ApplicationPage ApplicationPage { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            CloseWindowCommand = new RelayCommand(CloseWindow);
            DisplayPageCommand = new RelayCommand(DisplayPage);
        }

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CloseWindow(object source)
        {
            source.InvokeToMethod(Names.Close);
        }

        public void DisplayPage(object applicationPage)
        {
            ApplicationPage = applicationPage.ConvertTo<ApplicationPage>(); ;
        }
    }
}