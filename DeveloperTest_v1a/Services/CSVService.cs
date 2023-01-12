using CsvHelper;
using DeveloperTest_v1a.Interfaces;
using System.Globalization;

namespace DeveloperTest_v1a.Services
{
    public class CSVService : ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(string filename)
        {
            var reader = new StreamReader(filename);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<T>();
            return records;
        }
    }
}
