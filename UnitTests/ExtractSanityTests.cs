using DeveloperTest_v1a.Models;
using DeveloperTest_v1a.Services;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace UnitTests
{
    public class ExtractSanityTests
    {
        //arrange
        private List<ExpenseClaim> data = new List<ExpenseClaim>(); 

        [SetUp]
        public void Setup()
        {
            DataService dataService = new DataService();
            var result = dataService.LoadData();

            data = result.Result.ToList<ExpenseClaim>();
        }

        [Test]
        public void TestExtractIsNotEmpty()
        {
            Assert.IsTrue(data != null);
        }

        [Test]
        public void TestExtractAnyData()
        {
            Assert.IsTrue(data.Any());
        }

    }
}
