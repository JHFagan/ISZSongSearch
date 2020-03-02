using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISZSongSearch.Models
{
    public class Show
    {
        public Show() { }
        public int ID { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Song> SongsPlayed { get; set; }
    }
}
