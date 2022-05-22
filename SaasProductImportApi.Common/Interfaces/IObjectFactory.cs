

namespace SaasProductImportApi.Common.Interfaces
{
    public interface IObjectFactory
    {
        T Resolve<T>(string name);
    }
}
