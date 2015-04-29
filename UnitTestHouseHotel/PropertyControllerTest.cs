using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HouseHotel.Controllers;


namespace UnitTestHouseHotel
{
    [TestClass]
    public class PropertyControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new PropertyController();
            var result = controller.Details("12345");
            Assert.AreEqual(Property, result.

        }
    }
}
