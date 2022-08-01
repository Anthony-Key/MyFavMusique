using Microsoft.AspNetCore.Mvc;
using MyFavMusique.Data;
using MyFavMusique.Models;
using MyFavMusique.ViewModels;

namespace MyFavMusique.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPOST(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Search(int id)
        {
            var foundMusic = new List<Music>();

           var t = _context.Music.ToList();


            var fMusic = new FMusic
            {
                genreId = id,
                fMusic = foundMusic
            };

            return View(fMusic);
        }
    }
}
