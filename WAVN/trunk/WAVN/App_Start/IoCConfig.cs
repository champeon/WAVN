using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Linq;
using System.Web.Mvc;
using WAVN.Web;

namespace WAVN.App_Start
{
    public class IoCConfig
    {
        public static void RegisterDependencies()
        {
            #region Create the builder
            var builder = new ContainerBuilder();
            #endregion

            #region Setup a common pattern

            builder.RegisterAssemblyTypes()
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerHttpRequest();
            #endregion

            #region Register all controllers for the assembly
            builder.RegisterControllers(typeof(MvcApplication).Assembly)
                   .InstancePerHttpRequest();

            #endregion

            #region Register modules
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);
            #endregion

            #region Inject HTTP Abstractions

            builder.RegisterModule<AutofacWebTypesModule>();

            #endregion

            #region Set the MVC dependency resolver to use Autofac
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion

        }

    }
}