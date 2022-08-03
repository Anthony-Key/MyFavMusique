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

            t.ForEach(music =>
            {
                if(id == music.GenreId)
                {
                    foundMusic.Add(music);
                }
            });


            var fMusic = new FMusic
            {
                genreId = id,
                fMusic = foundMusic
            };

            return View(fMusic);
        }

        public IActionResult Found(int id)
        {
            var music = _context.Music.FirstOrDefault(music => music.Id == id);
            var url = "https://www.youtube.com/embed/";
            var cArr = music.Url.ToCharArray();
            var eUrl = "";

            for (int i = cArr.Length -1; i > 0; i--)
            {
                if(cArr[i] == '/')
                {
                    break;
                }

                eUrl += cArr[i];
            }

            music.Url = url + Reverse(eUrl);

            return View(music);
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
