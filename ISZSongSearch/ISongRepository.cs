using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISZSongSearch.Models;

namespace ISZSongSearch
{
    public interface ISongRepository
    {
        public IEnumerable<Song> GetAllSongs();
        //public Song GetSong(int id);
    }
}
