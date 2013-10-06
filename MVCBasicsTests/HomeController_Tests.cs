using System.Web.Mvc;
using MVCBasics.Controllers;
using NUnit.Framework;

namespace MVCBasicsTests
{
    [TestFixture]
    public class HomeController_Tests
    {
        private HomeController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new HomeController();
        }

        [Test]
        public void CanConstruct()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(_controller,Is.Not.Null);
        }

        [Test]
        public void Index_NormalUsage_ReturnsCorrectView()
        {
            //Arrange
            //Act
            var result =_controller.Index() as ViewResult;;
            //Assert
            Assert.That(result.ViewName,Is.EqualTo("Index"));
        }


    }
}
