using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Infra;
using Open.Infra.Patient;

namespace Open.Tests.Infra.Patient
{
    [TestClass]
    public class PatientObjectsRepositoryTests : ObjectTests<PatientObjectsRepository>
    {
        [TestMethod]
        public override void CanCreateTest()
        {
            Assert.IsNotNull(new PatientObjectsRepository(null));
        }

        protected override PatientObjectsRepository getRandomObject()
        {
            return null;
        }

        [TestMethod]
        public void GetObjectTest()
        {
            Assert.Inconclusive();
        }
        public void GetObjectsListTest()
        {
            Assert.Inconclusive();
        }
        public void AddObjectTest()
        {
            Assert.Inconclusive();
        }
        public void UpdateObjectTest()
        {
            Assert.Inconclusive();
        }
        public void DeleteObjectTest()
        {
            Assert.Inconclusive();
        }
        public void IsInitializedTest()
        {
            Assert.Inconclusive();
        }


    }
}
