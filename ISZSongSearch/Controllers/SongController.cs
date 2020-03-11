using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace ISZSongSearch.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongRepository repo;
        public SongController(ISongRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var songs = repo.GetAllSongs();
            return View(songs);

        }
        public IActionResult ViewSong(int id)
        {
            var song = repo.GetSong(id);
            return View(song);

            //var fileContents = System.IO.File.ReadAllText((@$"C:\Users\jhfag\Desktop\Repos\ISZSongSearch\ISZSongSearch\Content\Covers\{song.FilePath}"));
            //return Content(fileContents);

        }
    }
}