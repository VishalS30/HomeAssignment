using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaasProductImportApi.SoftwareAdviceAdapter;
using System.Linq;

namespace SaasProductImportApi.SoftwareAdviceAdapterTest
{
    [TestClass]
    public class SoftwareAdviceProductImportTest
    {
        private SoftwareAdviceProductImport softwareAdvice;

        [TestInitialize]
        public void Initialize()
        {
            softwareAdvice = new SoftwareAdviceProductImport();
        }

        [TestMethod]
        public void ImportProduct_Success_Test()
        {
            /*/Generally Test have three phase Act , Arrange and Assert 
             * As we dont have much dependcy on this class.Hence only using Act and Assert.
             / */

            // Act

            var response = softwareAdvice.ImportProduct().Result;

            // Assert

            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Count);
            Assert.AreEqual("Freshdesk", response.First().Name);
        }

        [TestCleanup]
        public void CleanUp()
        {
            softwareAdvice = null;
        }
    }
}