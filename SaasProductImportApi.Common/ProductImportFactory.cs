using SaasProductImportApi.Common.Interfaces;

namespace SaasProductImportApi.Common
{
    public class ProductImportFactory : IProductImportFactory
    {
        private readonly IObjectFactory _objectFactory;
        public ProductImportFactory(IObjectFactory objectFactory)
        {
            this._objectFactory = objectFactory;
        }
        public IProductImport GetProductImportInstance(string providerName)
        {
            return _objectFactory.Resolve<IProductImport>(providerName);
        }
    }
}