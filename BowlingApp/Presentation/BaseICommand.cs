using System;
using System.Windows.Input;

namespace BowlingApp.Presentation
{
    public class BaseICommand : ICommand
    {
        public delegate void DelegateAction();
        private readonly DelegateAction _delegateAction;

        public event EventHandler CanExecuteChanged;

        public BaseICommand(Action action)
        {
            _delegateAction = new DelegateAction(action);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _delegateAction();
        }
    }
}
