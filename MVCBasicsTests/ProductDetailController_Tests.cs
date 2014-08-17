using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class ProductDetailController_Tests
// ReSharper restore InconsistentNaming
    {
        private ProductDetailController _controller;
        private Mock<ICatalogueService> _catalogueServiceMock;
        private int _testproductid = 10;

        [SetUp]
        public void SetUp()
        {
            _catalogueServiceMock = new Mock<ICatalogueService>();
            _controller = new ProductDetailController(_catalogueServiceMock.Object);
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
            var result = _controller.Index(_testproductid) as ViewResult;

            //Assert
            Assert.That(result, Is.Not.Null);
            // ReSharper disable PossibleNullReferenceException
            Assert.That(result.ViewName, Is.EqualTo("ProductDetail"));
            // ReSharper restore PossibleNullReferenceException
        }

        [Test]
        public void Index_NormalUsage_ReturnsCorrectViewModelData()
        {
            //Arrange
            var stubProduct = new Product(_testproductid,"Sku123",10.0M,true);
            _catalogueServiceMock.Setup(m => m.RetrieveProductById(_testproductid)).Returns(stubProduct);

            //Act
            var result = _controller.Index(_testproductid) as ViewResult;

            //Assert
            // ReSharper disable PossibleNullReferenceException
            Assert.That(result.ViewData.Model, Is.Not.Null);
            var product = (Product)result.ViewData.Model;
            Assert.That(product.Id, Is.EqualTo(_testproductid));
            // ReSharper restore PossibleNullReferenceException
        }


    }
}
