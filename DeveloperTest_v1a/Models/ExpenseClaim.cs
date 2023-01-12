using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes; 

namespace DeveloperTest_v1a.Models
{
    public record ExpenseClaim {

        [Name("ID")]
        public int Id { get; init; }
        [Name("Claimant")]
        public string Claimant { get; init; } = "";

        [Name("Description")]
        public string Description { get; init; } = "";

        [Name("Office")]
        public string Office { get; init; } = "";
        
        [Name("Category")]
        public string Category { get; init; } = "";
        
        [Name("Price")]
        public decimal Amount { get; init; }
    }; 

}
