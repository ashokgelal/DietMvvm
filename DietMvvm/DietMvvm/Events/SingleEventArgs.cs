using System;

namespace DietMvvm.Events
{
    public class SingleEventArgs<T> : EventArgs
    {
        #region Properties

        public T ItsValue
        {
            get;
            private set;
        }

        #endregion Properties

        #region Constructors

        public SingleEventArgs(T val)
        {
            ItsValue = val;
        }

        #endregion Constructors
    }
}
