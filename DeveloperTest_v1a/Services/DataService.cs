using CsvHelper;
using DeveloperTest_v1a.Interfaces;
using DeveloperTest_v1a.Models;
using System.Globalization;
using System.IO;

namespace DeveloperTest_v1a.Services
{
    public class DataService 
    {

        private readonly ICSVService _csvService;


        public DataService(ICSVService csvService)
        {
            _csvService = csvService;
        }


        public IEnumerable<ExpenseClaim> LoadData()
        {
            string filename = @"C:\temp\test\DeveloperTest_v1a_Original\DeveloperTest_v1a\data.csv";

            var expenseClaims = _csvService.ReadCSV<ExpenseClaim>(filename);

            return expenseClaims; 
        }



    }
}
