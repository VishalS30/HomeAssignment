using SaasProductImportApi.Common.Models;

namespace SaasProductImportApi.Common.Interfaces
{
    public interface IProductImport
    {
        public Task<List<Response>> ImportProduct();
    }
}
