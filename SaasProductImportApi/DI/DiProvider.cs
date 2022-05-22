using Autofac;
using Autofac.Extensions.DependencyInjection;
using SaasProducImporiApi.BusinessLogic;
using SaasProducImporiApi.BusinessLogic.Interfaces;
using SaasProductImportApi.CapterraAdapter;
using SaasProductImportApi.Common.Interfaces;
using SaasProductImportApi.SoftwareAdviceAdapter;

namespace SaasProductImportApi.DI
{
    public static class DiProvider
    {
        public static IServiceProvider LoadDepedencies(IServiceCollection services, IConfiguration configuration)
        {
            var builder = new ContainerBuilder();
            // register services available in the container
            builder.Populate(services);

            builder.RegisterType<ProductBusinessLogic>().As<IProductBusinessLogic>();

            builder.RegisterType<Common.ObjectFactory>().As<IObjectFactory>();

            builder.RegisterType<Common.ProductImportFactory>().As<IProductImportFactory>();

            //Adapters will register as named and will resolve based on providerName.
            builder.RegisterType<CapterraProductImport>().Named<IProductImport>("Capterra");

            builder.RegisterType<SoftwareAdviceProductImport>().Named<IProductImport>("SoftwareAdvice");

            IContainer container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
