using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Comment> Comment { get; }
        IRepository<Game> Game { get; }
        IRepository<Genre> Genre { get; }
        IRepository<PlatformType> PlatformType { get; }
        IRepository<GameToGenre> GameToGenre { get; }
        IRepository<GameToPlatormType> GameToPlatformType { get; }
        void SaveChanges();
    }
}
