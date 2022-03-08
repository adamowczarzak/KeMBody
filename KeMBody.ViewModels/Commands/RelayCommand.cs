using System.Windows.Input;
using System;

namespace KeMBody.ViewModels
{
    public class RelayCommand : ICommand
    {
#pragma warning disable CS0067
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067

        private readonly Func<object, bool> canExecute;
        private readonly Action<object> actionWithParameter;
        private readonly Action action;

        public RelayCommand(Action action, Func<object, bool> canExecute = null)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> actionWithParameter)
        {
            this.actionWithParameter = actionWithParameter;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            actionWithParameter(parameter);
        }

        public void Execute()
        {
            action();
        }
    }
}
