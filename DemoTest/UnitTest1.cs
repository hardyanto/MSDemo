using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;
namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.Name, "Continuous Integration");
        }
    }
}
