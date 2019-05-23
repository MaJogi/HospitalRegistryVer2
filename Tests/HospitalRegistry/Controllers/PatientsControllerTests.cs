using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.HospitalRegistry.Controllers;

namespace Open.Tests.HospitalRegistry.Controllers
{
    [TestClass]
    public class PatientsControllerTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new PatientController(null));
        }
    }
}
