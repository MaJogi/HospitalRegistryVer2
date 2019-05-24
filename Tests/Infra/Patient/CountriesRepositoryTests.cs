using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
using Open.Data.Patient;
using Open.Infra.Patient;

namespace Open.Tests.Infra {

    [TestClass]
    public class
        PatientObjectsRepositoryTests 
       /* : PaginatedRepositoryTests<MoneyDbContext, Country, CountryData>*/ {
        //[TestInitialize] public override void TestInitialize() {
        //    base.TestInitialize();
        //    type = typeof(CountriesRepository);
        //}
        //protected override MoneyDbContext createContext(DbContextOptions<MoneyDbContext> builderOptions) {
        //    return new MoneyDbContext(builderOptions);
        //}
        //protected override string getRandomMemberStringValue(PatientDbRecord d)
        //{
        //    var i = GetRandom.UInt32() % 3;
        //    if (i == 0) return d.Code;
        //    if (i == 1) return d.Name;
        //    if (i == 2) return d.ID;
        //    return base.getRandomMemberStringValue(d);
        //}
        //protected override Func<PatientDbRecord, object> getRandomSortFunction()
        //{
        //    var i = GetRandom.UInt32() % 5;
        //    if (i == 0) return x => x.Code;
        //    if (i == 1) return x => x.ID;
        //    if (i == 2) return x => x.Name;
        //    if (i == 3) return x => x.ValidFrom;
        //    return x => x.ValidTo;
        //}
        //protected override DbSet<CountryData> getDbSet() => db.Countries;
        //protected override ICrudRepository<Country> getRepository() => new CountriesRepository(db);
        //protected override Country createObject(CountryData r) => new Country(r);
        //protected override CountryData getData(Country o) => o.Data;
        //protected override string getID(CountryData r) => r.ID;
        //protected override void setRandomValues(Country o) {
        //    o.Data.Name = GetRandom.String();
        //    o.Data.Code = GetRandom.String();
        //    base.setRandomValues(o);
        //}
        //protected override void validateDbRecords(PatientDbRecord e, PatientDbRecord a) {
        //    Assert.AreEqual(e.Name, a.Name);
        //    Assert.AreEqual(e.Code, a.Code);
        //    base.validateDbRecords(e, a);
        //}
        [TestMethod] public void CanCreate() {
            Assert.IsNotNull(new PatientObjectsRepository(null));
        }
    }
}


