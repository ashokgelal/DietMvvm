namespace DietMvvm.Events
{
    public class SingleArgsEventHandler<T> : GenericEventHandler<SingleEventArgs<T>>
    {
        public void Raise(object sender, T args)
        {
            base.Raise(sender, new SingleEventArgs<T>(args));
        }
    }
}