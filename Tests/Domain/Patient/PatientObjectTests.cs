using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Tests.Domain.Patient
{
    [TestClass]
    public class PatientObjectTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new PatientObject(new PatientDbRecord()));
        }
    }
}
