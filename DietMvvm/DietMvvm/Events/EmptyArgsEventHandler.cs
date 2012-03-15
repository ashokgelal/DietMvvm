using System;

namespace DietMvvm.Events
{
    public class EmptyArgsEventHandler : GenericEventHandler<EventArgs>
    {
        public void Raise(object sender)
        {
            base.Raise(sender, EventArgs.Empty);
        }
    }
}