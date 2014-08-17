using InventoryDomain.Interfaces;
using InventoryDomain.Services;
using NUnit.Framework;

namespace InventoryDomainTests.Services
{
    [TestFixture]
    public class CatalogueServiceTests
    {
        private ICatalogueService _service; 

        [SetUp]
        public void SetUp()
        {
            _service = new CatalogueService();
        } 


        [Test]
        public void Listproducts_NormalUsage_ReturnsCollectionOfListableProducts()
        {
            //Arrange

            //Act
            var actual = _service.ListProducts();

            //Assert
            Assert.That(actual,Is.Not.Null);
            Assert.That(actual.Count, Is.EqualTo(1000));
        }


        [Test]
        public void RetrieveProductById_NormalUsage_ReturnsProduct()
        {
            //Arrange

            //Act
            const int testId = 10;
            var actual = _service.RetrieveProductById(testId);

            //Assert
            Assert.That(actual,Is.Not.Null);
            Assert.That(actual.Id, Is.EqualTo(testId));
            Assert.That(actual.Sku, Is.EqualTo(string.Format("SKU0000{0}", testId)));
        }


    }
}
