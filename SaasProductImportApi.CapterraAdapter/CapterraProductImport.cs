using SaasProductImportApi.Common.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.Linq;
using SaasProductImportApi.Common.Interfaces;

namespace SaasProductImportApi.CapterraAdapter;

public class CapterraProductImport : IProductImport
{
    private List<Response> responses;
    public CapterraProductImport()
    {
        responses = new List<Response>();
    }
    async Task<List<Response>> IProductImport.ImportProduct()
    {
        var content = await File.ReadAllTextAsync(@"C:\Temp\Feeds\capterra.yaml");

        var deserializer = new DeserializerBuilder()
                       .WithNamingConvention(CamelCaseNamingConvention.Instance)
                       .Build();
        var product = deserializer.Deserialize<CapterraImportModel>(content);

        return await MapResponse(product.products, responses);
    }

    private async Task<List<Response>> MapResponse(List<CapterraProduct> products, List<Response> responseList)
    {
        responseList = products.Select(x => new Response
        {
            Categories = x.tags,
            Name = x.name,
            Twitter = x.twitter
        }).ToList();
        return await Task.FromResult(responseList);
    }
}
