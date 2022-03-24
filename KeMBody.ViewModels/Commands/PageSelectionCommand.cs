using KeMBody.Enumerations;
using KeMBody.Extensions;

namespace KeMBody.ViewModels
{
    public class PageSelectionCommand : RelayCommand
    {
        private readonly MainWindowViewModel mainWindowViewModel;

        public PageSelectionCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

        public override void Execute(object applicationPage)
        {
            mainWindowViewModel.ApplicationPage = applicationPage.ConvertTo<ApplicationPage>();
            mainWindowViewModel.SelectedPage = new SummaryViewModel();

            //OnPropertyChanged(nameof(SelectedPage));
        }
    }
}
