using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Facade.Patient;

namespace Open.Tests.Facade.Patient
{
    [TestClass]
    public class PatientViewModelTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new PatientViewModel());
        }
    }
}
