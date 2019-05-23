using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Facade.Patient;

namespace Open.Tests.Aids
{
    [TestClass]
    public class GetClassTests : BaseTests
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(GetClass);
        }
        internal class classTest : PublicBindingFlagsForTests.testClass
        {
            public int E = 0;
            public string F { get; set; }
        }
        [TestMethod]
        public void NamespaceTest()
        {
            var t = typeof(object);
            Assert.AreEqual(t.Namespace, GetClass.Namespace(t));
            Assert.AreEqual(string.Empty, GetClass.Namespace(null));
        }
        [TestMethod]
        public void MembersTest()
        {
            testMember(typeof(classTest));
            testNull(null);
        }
        private static void testNull(Type t)
        {
            var a = GetClass.Members(t);
            Assert.IsInstanceOfType(a, typeof(List<MemberInfo>));
            Assert.AreEqual(0, a.Count);
        }
        private static void testMember(Type t)
        {
            var a = GetClass.Members(t, PublicBindingFlagsFor.AllMembers, false);
            var e = t.GetMembers(PublicBindingFlagsFor.AllMembers);
            Assert.AreEqual(e.Length, a.Count);
            Assert.AreEqual(10, a.Count);
            foreach (var v in e) Assert.IsTrue(a.Contains(v));
            Assert.AreEqual(7, GetClass.Members(t).Count);
        }
        [TestMethod]
        public void PropertiesTest()
        {
            var a = GetClass.Properties(typeof(classTest));
            Assert.IsNotNull(a);
            Assert.IsInstanceOfType(a, typeof(List<PropertyInfo>));
            Assert.AreEqual(1, a.Count);
            Assert.AreEqual("F", a[0].Name);
        }
        [TestMethod]
        public void ReadWritePropertyValuesTest()
        {
            var o = GetRandom.Object<classTest>();
            var l = GetClass.ReadWritePropertyValues(o);
            Assert.AreEqual(1, l.Count);
            Assert.AreEqual(l[0], o.F);
        }
        [TestMethod]
        public void PropertyTest()
        {
            void test(string name)
            {
                Assert.AreEqual(name, GetClass.Property<PatientViewModel>(name).Name);
            }
            Assert.IsNull(GetClass.Property<PatientViewModel>((string)null));
            Assert.IsNull(GetClass.Property<PatientViewModel>(string.Empty));
            Assert.IsNull(GetClass.Property<PatientViewModel>("bla bla"));
            test(GetMember.Name<PatientViewModel>(m => m.FirstName));
            test(GetMember.Name<PatientViewModel>(m => m.LastName));
            test(GetMember.Name<PatientViewModel>(m => m.IdCode));
            test(GetMember.Name<PatientViewModel>(m => m.Problem));
            test(GetMember.Name<PatientViewModel>(m => m.PhoneNumber));
            //test(GetMember.Name<PatientViewModel>(m => m.ProblemColor));
            test(GetMember.Name<PatientViewModel>(m => m.ValidFrom));
            test(GetMember.Name<PatientViewModel>(m => m.ValidTo));
        }
    }
}
