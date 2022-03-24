using System.ComponentModel;
using System.Windows.Input;
using KeMBody.Enumerations;
using KeMBody.Extensions;

namespace KeMBody.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public BaseViewModel SelectedPage { get; internal set; }
        public ApplicationPage ApplicationPage { get; internal set; }
        public ICommand PageSelectionCommand { get; private set; }
        public ICommand CloseWindowCommand { get; private set; }

        public MainWindowViewModel()
        {
            CloseWindowCommand = new RelayCommand(CloseWindow);
            PageSelectionCommand = new PageSelectionCommand(this);
        }

        public void CloseWindow(object source)
        {
            source.InvokeToMethod(Names.Close);
        }
    }
}