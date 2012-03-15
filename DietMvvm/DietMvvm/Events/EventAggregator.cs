using System;

namespace DietMvvm.Events
{
    public abstract class EventAggregator
    {
        #region Public Methods

        public void PublishEvent<T>(GenericEventHandler<T> handler, T args)
            where T : EventArgs
        {
            handler.Raise(this, args);
        }

        public void PublishEvent<T>(SingleArgsEventHandler<T> handler, T obj)
        {
            handler.Raise(this, obj);
        }

        public void PublishEvent(EmptyArgsEventHandler handler)
        {
            handler.Raise(this);
        }

        #endregion Public Methods
    }
}
