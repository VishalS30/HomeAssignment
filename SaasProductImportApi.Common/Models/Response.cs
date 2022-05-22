using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasProductImportApi.Common.Models
{
    public class Response
    {
        /// <summary>
        /// Product Categories
        /// </summary>
        public List<string> Categories { get; set; }
        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Twitter Handle
        /// </summary>
        public string Twitter { get; set; }
        /// <summary>
        /// This is very good concept. If any provider is sendiny any extra info then we can capture in additional data without changing response.
        /// </summary>
        public Dictionary<string, object> AdditionalData { get; set; }
    }
}
