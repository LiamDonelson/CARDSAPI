using CardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CardsAPI.Controllers
{
    public class HomeController : Controller
    {
        DrawDeckDAL api = new DrawDeckDAL();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DrawnDeck(int Id)
        {
            DrawDeck d = api.GetDeck(Id);
            Deck ass = api.Deckitems(d.deck_id);
            return View(ass);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}