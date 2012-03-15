using System;
using System.Windows.Input;

namespace DietMvvm
{
    public class ViewModelCommand<T> : ICommand
    {
        #region Fields

        private readonly Func<T, bool> _canExecute;
        private readonly Action<T> _executeAction;

        #endregion Fields

        #region Events

        public event EventHandler CanExecuteChanged;

        #endregion Events

        #region Constructors

        public ViewModelCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            _executeAction = execute;
            _canExecute = canExecute;
        }

        public ViewModelCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        #endregion Constructors

        #region Public Methods

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            if(CanExecute(parameter))
            {
                _executeAction((T) parameter);
            }
        }

        public virtual void OnCanExecuteChanged(EventArgs e)
        {
            var handler = CanExecuteChanged;
            if (handler != null)
                handler(this, e);
        }

        public void RaiseCanExecuteChanged()
        {
            OnCanExecuteChanged(EventArgs.Empty);
        }

        #endregion Public Methods
    }
}