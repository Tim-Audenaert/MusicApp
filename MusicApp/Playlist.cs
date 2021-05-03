using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Playlist
    {
        public Playlist()
        {
            this.Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [Column(Order = 2)]
        public ICollection<Song> Songs { get; set; }
    }
}
