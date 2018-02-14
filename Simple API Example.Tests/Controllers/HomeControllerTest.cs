using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_API_Example;
using Simple_API_Example.Controllers;

namespace Simple_API_Example.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
