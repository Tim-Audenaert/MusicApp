using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Song
    {
        public Song()
        {
            this.Playlists = new HashSet<Playlist>();
        }
        public int Id { get; set; }
        public Album Album { get; set; }
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public DateTime Length { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
