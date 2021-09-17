using ModelBookUser.ViewModels;
using ModelBookUser.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModelBookUser
{
    public class ModuleName : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
