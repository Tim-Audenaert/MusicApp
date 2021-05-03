using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    class AccountContext : DbContext
    {
        public AccountContext() : base("name=MusicApp")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<AccountContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<AccountContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccountContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

    }
}
