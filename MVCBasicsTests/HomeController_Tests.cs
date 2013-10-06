using System.Web.Mvc;
using MVCBasics.Controllers;
using NUnit.Framework;

namespace MVCBasicsTests
{
    [TestFixture]
    // ReSharper disable InconsistentNaming
    public class HomeController_Tests
    // ReSharper restore InconsistentNaming
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
            var result =_controller.Index() as ViewResult;

            //Assert
            Assert.That(result, Is.Not.Null);
            // ReSharper disable PossibleNullReferenceException
            Assert.That(result.ViewName, Is.EqualTo("Index"));
            // ReSharper restore PossibleNullReferenceException
        }


    }
}
