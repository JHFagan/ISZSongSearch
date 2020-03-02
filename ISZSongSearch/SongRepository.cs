using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISZSongSearch.Models;
using Dapper;
using System.Data;

namespace ISZSongSearch
{
    public class SongRepository : ISongRepository
    {
        private readonly IDbConnection _conn;
        public SongRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Song> GetAllSongs()
        {
            return _conn.Query<Song>("SELECT * FROM Songs;");
        }
        //public Song GetSong(int id);
    }
}
