using System;
using System.Windows.Input;

namespace DietMvvm
{
    public class ViewModelCommand : ICommand
    {
        #region Fields

        private readonly Func<bool> _canExecute;
        private readonly Action _executeAction;

        #endregion Fields

        #region Events

        public event EventHandler CanExecuteChanged;

        #endregion Events

        #region Constructors

        public ViewModelCommand(Action execute, Func<bool> canExecute)
        {
            _executeAction = execute;
            _canExecute = canExecute;
        }

        public ViewModelCommand(Action execute)
            : this(execute, null)
        {
        }

        #endregion Constructors

        #region Public Methods

        public virtual bool CanExecute(object parameter)
        {
            return _canExecute== null || _canExecute();
        }

        public virtual void Execute(object parameter)
        {
            if (CanExecute(parameter))
                _executeAction();
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