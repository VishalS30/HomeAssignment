using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasProductImportApi.Common.Models
{
    public class SoftwareAdviceImportModel
    {
        public List<SoftwareAdviceProduct> products { get; set; }
    }

    public class SoftwareAdviceProduct
    {
        public List<string> categories { get; set; }
        public string title { get; set; }
        public string twitter { get; set; }
    }
}
