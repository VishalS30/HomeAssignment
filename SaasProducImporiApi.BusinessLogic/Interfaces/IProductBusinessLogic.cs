using SaasProductImportApi.Common.Models;
namespace SaasProducImporiApi.BusinessLogic.Interfaces
{
    public interface IProductBusinessLogic
    {
        Task<List<Response>> ImportProducts(string providerName);
    }
}
