using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DeveloperTest_v1a.Services;
using DeveloperTest_v1a.Models;

namespace DeveloperTest_v1a.Pages
{
    public class IndexModel : PageModel
    {

    private readonly ILogger<IndexModel> _logger;
    public List<ExpenseClaim> expenseClaim { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            //expenseClaim = new ExpenseClaim(); 
            expenseClaim = new List<ExpenseClaim>(); 
        }





    public void OnGet()
        {

            DataService dataService = new DataService();
            var data = dataService.LoadData();

            List<ExpenseClaim> stuff = new List<ExpenseClaim>();
            expenseClaim = data.Result.ToList<ExpenseClaim>();
        }
    }
}