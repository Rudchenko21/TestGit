using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL
{
   public class GameStoreContext:DbContext
    {
       static GameStoreContext()
       {
           Database.SetInitializer<GameStoreContext>(new GameStoreDbInitializer());
       }
        public GameStoreContext() : base("GameStore")
        {}
        public virtual DbSet<Comment> Comments { get; set; }
        public  DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlatformType> PlatformTypes { get; set; }


    }
}
