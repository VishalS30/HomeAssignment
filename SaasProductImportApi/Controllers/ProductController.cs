using Microsoft.AspNetCore.Mvc;
using SaasProducImporiApi.BusinessLogic.Interfaces;

namespace SaasProductImportApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductBusinessLogic _productBusinessLogic;
        public ProductController(IProductBusinessLogic productBusinessLogic)
        {
            _productBusinessLogic = productBusinessLogic;
        }
        /// <summary>
        /// Capterra And SoftwareAdvice can be used as providers.
        /// </summary>
        /// <param name="providerName"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ImportProduct(string providerName)
        {
            try
            {
                if (!string.IsNullOrEmpty(providerName))
                {
                    var result = await _productBusinessLogic.ImportProducts(providerName);
                    return Ok(result);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
