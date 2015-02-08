using System;
using System.Windows.Input;

namespace MVVMBasic.ViewModels.Base
{
    public class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;

            return _canExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_execute != null)
                _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(null, new EventArgs());
        }
    }

    public class DelegateCommand<T> : ICommand
    {
        private Action<T> _execute;
        private Func<T, bool> _canExecute;

        public DelegateCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;

            return _canExecute((T) parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_execute != null)
                _execute((T) parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(null, new EventArgs());
        }
    }
}
