using System;

namespace DietMvvm.Events
{
    public class GenericEventHandler<T> where T : EventArgs
    {
        public event EventHandler<T> ItsEvent = delegate { };

        public virtual void Raise(object sender, T args)
        {
            ItsEvent.Raise(sender, args);
        }
    }
}