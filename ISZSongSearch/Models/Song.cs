using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISZSongSearch.Models
{
    public class Song
    {
        public Song()
        {
        }
        public int ID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
    }
}
