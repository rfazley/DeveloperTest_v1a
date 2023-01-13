using CsvHelper;
using DeveloperTest_v1a.Interfaces;
using DeveloperTest_v1a.Models;
using DeveloperTest_v1a.Services;
using NUnit.Framework;
using System.Globalization;

namespace UnitTests
{

    
    public class ExtractSanityTests
    {
        //arrange
        private List<ExpenseClaim> data = new List<ExpenseClaim>();
        
        [SetUp]
        public void Setup()
        {
            string filename = @"C:\temp\test\DeveloperTest_v1a_Original\DeveloperTest_v1a\data.csv";

            var reader = new StreamReader(filename);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<ExpenseClaim>();

            data = records.ToList<ExpenseClaim>();
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
