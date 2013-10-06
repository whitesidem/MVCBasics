using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MVCBasics.IOC;

namespace MVCBasics.App_Start
{
    public static class IocBootstrapContainer
    {

        private static IWindsorContainer _container;


        public static void RegisterIoc()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());
            var controllerFactory = new IocControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
         
        public static void  DisposeIoc()
        {
            if(_container!=null)
                _container.Dispose();
        }


    }
}