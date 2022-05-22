using Autofac;
using SaasProductImportApi.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasProductImportApi.Common
{
    public class ObjectFactory : IObjectFactory
    {
        private readonly IComponentContext _componentContext;
        public ObjectFactory(IComponentContext container)
        {
            this._componentContext = container;
        }
        public TService Resolve<TService>(string serviceName)
        {
            if (!string.IsNullOrEmpty(serviceName) && _componentContext.IsRegisteredWithName<TService>(serviceName))
            {
                return _componentContext.ResolveNamed<TService>(serviceName);
            }
            return default(TService);

        }
    }
}
