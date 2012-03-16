using Microsoft.Practices.Unity;

namespace DietMvvm
{
    public abstract class ViewModelLocatorBase
    {
        protected static IUnityContainer _container;

        static ViewModelLocatorBase()
        {
            _container = new UnityContainer();
        }
    }
}
