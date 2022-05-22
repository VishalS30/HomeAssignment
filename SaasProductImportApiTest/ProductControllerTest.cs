using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SaasProducImporiApi.BusinessLogic.Interfaces;
using SaasProductImportApi.Controllers;

namespace SaasProductImportApiTest
{
    [TestClass]
    public class ProductControllerTest
    {
        private Mock<IProductBusinessLogic> mockProductBusinessLogic;
        private ProductController controller;

        [TestInitialize]
        public void Initialize()
        {
            mockProductBusinessLogic = new Mock<IProductBusinessLogic>();
            controller = new ProductController(mockProductBusinessLogic.Object);
        }

        [TestMethod]
        public void ImportProduct_WhenProvider_IsNullOrEmpty()
        {
        }
    }
}