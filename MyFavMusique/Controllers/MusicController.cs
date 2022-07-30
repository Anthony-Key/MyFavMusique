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
            var musicGenre = new MusicGenre
            {
                Id = id,
                music = new Music()
            };
            return View(musicGenre);
        }

        [HttpPost]
        public IActionResult AddPOST(MusicGenre music)
        {
            _context.Music.Add(music.music);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
