//using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_tdd.se.claremont;
using net_tdd.se.claremont.util;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class DatabaseClientTest
    {
        [Test]
        public void getDataFromDatabase()
        {
            VehiclePremium vp = new VehiclePremium();
            vp.licencePlate = "ABC123";
            vp.insurancePremium = 666;

            DatabaseClient.writeToDatabase(vp);

            Assert.AreEqual(666, DatabaseClient.readFromDatabase("ABC123").insurancePremium);
        }
    }
}
