using DeveloperTest_v1a.Interfaces;
using DeveloperTest_v1a.Models;
using DeveloperTest_v1a.Services;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace UnitTests
{
    public class ExtractSanityTests
    {
        private ICSVService ?_csvService;
        //arrange
        private List<ExpenseClaim> data = new List<ExpenseClaim>(); 

        [SetUp]
        public void Setup(ICSVService csvService)
        {
            _csvService = csvService;

            DataService dataService = new DataService(_csvService);
            var result = dataService.LoadData();

            data = result.ToList<ExpenseClaim>();
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
