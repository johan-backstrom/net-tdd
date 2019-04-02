//using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_tdd.se.claremont.util;
using NUnit.Framework;
using System.Linq;

namespace Test.se.claremont
{
    [TestFixture]
    public class FileReadingUtilityTest
    {
        [Test]
        public void readFile()
        {
            FileReadingUtility readFile = new FileReadingUtility();

            Assert.AreEqual(2, readFile.readFileLinesFromResources(@"C:\Users\Kristoffer Hemlin\Desktop\net-tdd\net-tdd\se.claremont\cars.txt").Count());
        }
    }
}
