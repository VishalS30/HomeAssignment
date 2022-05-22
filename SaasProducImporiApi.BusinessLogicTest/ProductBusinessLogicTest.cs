using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SaasProducImporiApi.BusinessLogic;
using SaasProductImportApi.Common.Interfaces;
using SaasProductImportApi.Common.Models;
using System.Collections.Generic;
using System.Linq;

namespace SaasProducImporiApi.BusinessLogicTest
{
    [TestClass]
    public class ProductBusinessLogicTest
    {
        private Mock<IProductImportFactory> mockProductimportFactory;
        private Mock<IProductImport> mockProductImport;
        private ProductBusinessLogic businessLogic;

        [TestInitialize]
        public void Initialize()
        {
            mockProductimportFactory = new Mock<IProductImportFactory>();
            mockProductImport = new Mock<IProductImport>();
            businessLogic = new ProductBusinessLogic(mockProductimportFactory.Object);
        }

        [TestMethod]
        public void ImportProducts_WhenProvider_IsValid_Test()
        {
            //Arrange
            mockProductImport
                .Setup(x => x.ImportProduct())
                .ReturnsAsync(new List<Response> {
                    new Response{
                         Categories = new List<string>{ "Bug Reporting Tool"},
                         Name = "Jira",
                         Twitter = "@Jira"
                    }});

            mockProductimportFactory
                .Setup(x => x.GetProductImportInstance(It.IsAny<string>()))
                .Returns(mockProductImport.Object);

            //Act

            var result = businessLogic.ImportProducts(It.IsAny<string>()).Result;

            // Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Jira", result.First().Name);
        }

        [TestMethod]
        public void ImportProducts_WhenProvider_IsNotValid_Test()
        {
            //Arrange
            mockProductImport
                .Setup(x => x.ImportProduct())
                .ReturnsAsync(new List<Response>());

            mockProductimportFactory
                .Setup(x => x.GetProductImportInstance(It.IsAny<string>()))
                .Returns(mockProductImport.Object);

            //Act

            var result = businessLogic.ImportProducts(It.IsAny<string>()).Result;

            // Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}