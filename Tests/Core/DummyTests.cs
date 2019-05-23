using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Core
{
    [TestClass]
    public class DummyTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new DummyTests());
        }
    }
}
