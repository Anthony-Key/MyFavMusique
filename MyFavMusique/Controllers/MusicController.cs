using Microsoft.AspNetCore.Mvc;
using MyFavMusique.Data;
using MyFavMusique.Models;
using MyFavMusique.ViewModels;

namespace MyFavMusique.Controllers
{
    public class MusicController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusicController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int id)
        {
            Genre? genre = _context.Genres.FirstOrDefault(x => x.Id == id);
            Music music = new Music(genre);
            return View(music);
        }

        [HttpPost]
        public IActionResult AddPOST(Music music)
        {
            music.Genre = _context.Genres.FirstOrDefault(g => g.Id == music.Genre.Id);
            _context.Music.Add(music);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
