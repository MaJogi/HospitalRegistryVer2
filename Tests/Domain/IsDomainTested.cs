using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests.Domain {
    [TestClass] public class IsDomainTested : AssemblyTests {
        private const string assembly = "Open.Domain.Patient"; //or should it be without .Patient?
        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }
        //[TestMethod]
        //public void IsIPatientObjectsRepositoryTested()
        //{
        //    isAllTested(assembly, Namespace("IPatientObjectsRepository"));
        //}
        [TestMethod]
        public void IsPatientObjectTested()
        {
            isAllTested(assembly, Namespace("PatientObject"));
        }
        [TestMethod]
        public void IsPatientObjectFactoryTested()
        {
            isAllTested(assembly, Namespace("PatientObjectFactory"));
        }
        [TestMethod]
        public void IsPatientObjectsListTested()
        {
            isAllTested(assembly, Namespace("PatientObjectsList"));
        }
        //[TestMethod] public void IsProcessTested() {
        //    isAllTested(assembly, Namespace("Process"));
        //}
        //[TestMethod] public void IsProductTested() {
        //    isAllTested(assembly, Namespace("Product"));
        //}
        //[TestMethod] public void IsQuantityTested() {
        //    isAllTested(assembly, Namespace("Quantity"));
        //}
        //[TestMethod] public void IsRuleTested() {
        //    isAllTested(assembly, Namespace("Rule"));
        //}
        [TestMethod]
        public void IsTested()
        {
            isAllTested(base.Namespace("Domain"));
        }

    }
}



