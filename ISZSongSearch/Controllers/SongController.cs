using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
    }
}