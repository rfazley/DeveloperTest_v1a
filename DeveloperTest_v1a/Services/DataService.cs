using CsvHelper;
using DeveloperTest_v1a.Models;
using System.Globalization;
using System.IO;

namespace DeveloperTest_v1a.Services
{
    public class DataService 
    {



        public async Task<IEnumerable<ExpenseClaim>> LoadData()
        {
            // Replace this line with code to load data from data.csv
            await Task.CompletedTask;

            string filename = @"C:\temp\test\DeveloperTest_v1a_Original\DeveloperTest_v1a\data.csv";

            List<ExpenseClaim> expenseClaim = new List<ExpenseClaim>();

            using (var streamReader = new StreamReader(filename))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    expenseClaim = csvReader.GetRecords<ExpenseClaim>().ToList();
                }
            }
            return expenseClaim;
        }
    }
}
