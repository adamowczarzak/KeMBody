using System;
using System.Windows.Input;

namespace KeMBody.ViewModels
{
    public class RelayCommand : ICommand
    {
#pragma warning disable CS0067
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067

        private readonly Func<object, bool> canExecute;
        private readonly Action action;

        public RelayCommand(Action action, Func<object, bool> canExecute = null)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
