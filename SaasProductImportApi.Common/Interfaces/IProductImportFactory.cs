namespace SaasProductImportApi.Common.Interfaces
{
    public interface IProductImportFactory
    {
        IProductImport GetProductImportInstance(string providerName);
    }
}
