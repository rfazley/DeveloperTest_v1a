using DeveloperTest_v1a.Services;
using NUnit.Framework;

namespace DeveloperTest_v1a.Tests
{
    [TestFixture]
    public class DataLoading
    {
        [Test]
        public async Task DataServiceReturnsData()
        {
            DataService dataService = new DataService();
            var data = await dataService.LoadData();

            Assert.IsTrue(data != null);
            Assert.IsTrue(data.Any());
        }
    }
}
