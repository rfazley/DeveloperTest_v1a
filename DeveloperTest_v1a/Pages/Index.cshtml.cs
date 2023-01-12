using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DeveloperTest_v1a.Services;
using DeveloperTest_v1a.Models;
using DeveloperTest_v1a.Interfaces;

namespace DeveloperTest_v1a.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ICSVService _csvService;

        private readonly ILogger<IndexModel> _logger;
        private List<ExpenseClaim> expenseClaim { get; set; }


        public IndexModel(ILogger<IndexModel> logger, ICSVService csvService)
        {
            _logger = logger;
            expenseClaim = new List<ExpenseClaim>();
            _csvService = csvService;

        }


        public void OnGet()
        {
            DataService dataService = new DataService(_csvService);
            var data = dataService.LoadData();
           
            expenseClaim = data.ToList<ExpenseClaim>();
        }
    }
}