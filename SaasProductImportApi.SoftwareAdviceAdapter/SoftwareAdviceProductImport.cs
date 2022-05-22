using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SaasProducImporiApi.BusinessLogic.Interfaces;
using SaasProductImportApi.Common.Interfaces;
using SaasProductImportApi.Common.Models;
using System.Reflection;

namespace SaasProductImportApi.SoftwareAdviceAdapter;

public class SoftwareAdviceProductImport : IProductImport
{
    private readonly List<Response> response;
    public SoftwareAdviceProductImport()
    {
        response = new List<Response>();
    }

    public async Task<List<Response>> ImportProduct()
    {
        //Need to place feed folder in C:\Temp.
        string productsJson = JObject.Parse(File.ReadAllText(@"C:\Temp\Feeds\softwareadvice.json")).ToString();

        SoftwareAdviceImportModel? product = JsonConvert.DeserializeObject<SoftwareAdviceImportModel>(productsJson);

        if (product != null)
        {
            // We can call respository from here to import product in database. As no Db is configured simply returning the response.
            return await MapResponse(product.products, response);
        }

        return response;
    }

    private async Task<List<Response>> MapResponse(List<SoftwareAdviceProduct> products, List<Response> responseList)
    {
        responseList = products.Select(x => new Response
        {
            Categories = x.categories.ToList(),
            Name = x.title,
            Twitter = x.twitter
        }).ToList();


        return await Task.FromResult(responseList);
    }
}
