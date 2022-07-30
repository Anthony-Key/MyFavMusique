using Microsoft.AspNetCore.Mvc;
using MyFavMusique.Data;
using MyFavMusique.Models;
using MyFavMusique.ViewModels;
using System.Diagnostics;

namespace MyFavMusique.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var genres = new Genres
            {
                genres = _context.Genres.ToList()
            };

            return View(genres);
        }
    }
}