using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseService _databaseService;

        public HomeController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            _databaseService = new DatabaseService(connectionString);
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            var structure = await _databaseService.GetDatabaseStructureAsync();
            return View(structure);
        }

        [HttpPost("/execute")]
        public async Task<IActionResult> Execute(string query)
        {
            var result = await _databaseService.ExecuteQueryAsync(query);
            return View("QueryResult", result);
        }
    }
}
