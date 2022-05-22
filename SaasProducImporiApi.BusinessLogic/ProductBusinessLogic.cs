using SaasProducImporiApi.BusinessLogic.Interfaces;
using SaasProductImportApi.Common.Interfaces;
using SaasProductImportApi.Common.Models;

namespace SaasProducImporiApi.BusinessLogic
{
    /// <summary>
    /// This class is responsible to handle business logic.
    /// </summary>
    public class ProductBusinessLogic : IProductBusinessLogic
    {
        private readonly IProductImportFactory _productImportFactory;
        private List<Response> result;
        public ProductBusinessLogic(IProductImportFactory productImportFactory)
        {
            _productImportFactory = productImportFactory;
            result = new List<Response>();
        }
        public async Task<List<Response>> ImportProducts(string providerName)
        {
            // Abstract Factory Patttern
            IProductImport? productImport = _productImportFactory.GetProductImportInstance(providerName);
            if (productImport != null)
            {
                // Adapter Pattern
                result = await productImport.ImportProduct();
            }
            return result;
        }
    }
}