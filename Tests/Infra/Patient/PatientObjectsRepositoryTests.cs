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
    public class PatientObjectsRepositoryTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            DbContextOptions<RegistryDbContext> options = new DbContextOptions<RegistryDbContext>(); 
            Assert.IsNotNull(new PatientObjectsRepository(new RegistryDbContext(options)));
        }
    }
}
