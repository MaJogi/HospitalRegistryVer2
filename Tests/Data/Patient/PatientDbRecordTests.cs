using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Patient;

namespace Open.Tests.Data.Patient
{
    [TestClass]
    public class PatientDbRecordTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new PatientDbRecord());
        }

    }
}
