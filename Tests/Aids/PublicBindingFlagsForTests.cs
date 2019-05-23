using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Open.Tests.Aids
{
    [TestClass]
    public class PublicBindingFlagsForTests
    {
        private const BindingFlags p = BindingFlags.Public;
        private const BindingFlags i = BindingFlags.Instance;
        private const BindingFlags s = BindingFlags.Static;
        private const BindingFlags d = BindingFlags.DeclaredOnly;
        private Type testType;

        public void Aaa() { bbb(); }
        private void bbb() { }
        public static void Ccc() { ddd();  }
        private static void ddd() { }
        //To be continiued...
    }
}
