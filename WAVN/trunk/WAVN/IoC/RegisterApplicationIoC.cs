using Autofac;
using Autofac.Integration.Mvc;
using WAVN.Services;

namespace WAVN.IoC
{
    public class RegisterApplicationIoC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CalculateService>()
                   .As<ICalculateService>()
                   .InstancePerHttpRequest();
        }
    }
}