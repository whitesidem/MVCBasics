using System.Collections.Generic;
using System.Web.Mvc;
using InventoryDomain.Interfaces;
using InventoryDomain.Models;
using MVCBasics.Controllers;
using Moq;
using NUnit.Framework;

namespace MVCBasicsTests
{

    [TestFixture]
    // ReSharper disable InconsistentNaming
    public class Productcontroller_Tests
    // ReSharper restore InconsistentNaming
    {
        private ProductController _controller;
        private Mock<ICatalogueService> _catalogueServiceMock;


        [SetUp]
        public void SetUp()
        {
            _catalogueServiceMock = new Mock<ICatalogueService>();
            _controller = new ProductController(_catalogueServiceMock.Object);
        }

        [Test]
        public void CanConstruct()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(_controller, Is.Not.Null);
        }

        [Test]
        public void Index_NormalUsage_ReturnsCorrectView()
        {
            //Arrange
            //Act
            var result = _controller.List() as ViewResult;

            //Assert
            Assert.That(result, Is.Not.Null);
            // ReSharper disable PossibleNullReferenceException
            Assert.That(result.ViewName, Is.EqualTo("Products"));
            // ReSharper restore PossibleNullReferenceException
        }

        [Test]
        public void Index_NormalUsage_ReturnsCorrectViewModelData()
        {
            //Arrange
            var stubListableProducts = new List<ListableProduct>();
            _catalogueServiceMock.Setup(m => m.ListProducts()).Returns(stubListableProducts);

            //Act
            var result = _controller.List() as ViewResult;

            //Assert
            // ReSharper disable PossibleNullReferenceException
            Assert.That(result.ViewData.Model, Is.Not.Null);
            var products = (List<ListableProduct>) result.ViewData.Model;
            Assert.That(products, Is.EqualTo(stubListableProducts));
            // ReSharper restore PossibleNullReferenceException
        }

    }
}
