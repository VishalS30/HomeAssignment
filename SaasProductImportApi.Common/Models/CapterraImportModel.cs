namespace SaasProductImportApi.Common.Models
{
    public class CapterraImportModel
    {
        public List<CapterraProduct> products { get; set; }
    }

    public class CapterraProduct
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
        public string twitter { get; set; }
    }
}
