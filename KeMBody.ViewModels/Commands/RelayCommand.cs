using System.Windows.Input;
using System;

namespace KeMBody.ViewModels
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Func<object, bool> canExecute;
        private readonly Action<object> actionWithParameter;
        private readonly Action action;

        public RelayCommand() { }

        public RelayCommand(Action action, Func<object, bool> canExecute = null)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> actionWithParameter, Func<object, bool> canExecute = null)
        {
            this.actionWithParameter = actionWithParameter;
            this.canExecute = canExecute;
        }

        public virtual void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public virtual bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public virtual void Execute(object parameter)
        {
            actionWithParameter(parameter);
        }

        public virtual void Execute()
        {
            action();
        }
    }
}
