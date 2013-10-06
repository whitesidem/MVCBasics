using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCBasics.Controllers;
using NUnit.Framework;

namespace MVCBasicsTests
{

    [TestFixture]
    public class Productcontroller_Tests
    {

        [Test]
        public void CanConstruct()
        {
            //Arrange

            //Act
            var controller = new ProductController();

            //Assert
            Assert.That(controller, Is.Not.Null);
        }


    }
}
