using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISIVIC.SP.UI.Host;
using ISIVIC.SP.UI.Host.Controllers;

namespace ISIVIC.SP.UI.Host.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
