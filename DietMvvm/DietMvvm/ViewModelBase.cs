using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DietMvvm
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Protected Methods

        protected void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            if (property == null)
                return;
            OnPropertyChanged(new PropertyChangedEventArgs(((MemberExpression)property.Body).Member.Name));
        }

        #endregion Protected Methods

        #region Private Methods

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        #endregion Private Methods
    }
}