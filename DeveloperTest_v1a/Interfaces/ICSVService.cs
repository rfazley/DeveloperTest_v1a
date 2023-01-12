namespace DeveloperTest_v1a.Interfaces
{
    public interface ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(string filename);
    }
}
