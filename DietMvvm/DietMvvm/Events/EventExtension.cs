using System;

namespace DietMvvm.Events
{
    public static class EventHelper
    {
        #region Public Methods

        public static void Raise<T>(this EventHandler<T> handler, object sender, T eventArgs)
            where T : EventArgs
        {
            handler(sender, eventArgs);
        }

        public static void Raise(this EventHandler handler, object sender, EventArgs eventArgs)
        {
            handler(sender, eventArgs);
        }

        #endregion Public Methods
    }
}
