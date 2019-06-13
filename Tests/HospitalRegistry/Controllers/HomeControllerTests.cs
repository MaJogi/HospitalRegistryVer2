using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.HospitalRegistry.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.HospitalRegistry.Controllers
{
    [TestClass]
    class HomeControllerTests
    {
        //[TestMethod]
        //public void TestHomeControllerIndexIsNull()
        //{
        //    var controller = new HomeController();
        //    var result = controller.Index() as ViewResult;
        //    Assert.IsNull(result.ViewName);
        //}

        [TestMethod]
        public void CanCreateHomeController()
        {
            Assert.IsNotNull(new HomeController());
        }
    }
}
