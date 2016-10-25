﻿using MVCTask1.DAL.Interfaces;
using MVCTask1.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly GameStoreContext db;
        private Repository<Game> game;
        private Repository<Comment> comment;
        private Repository<Genre> genre;
        private Repository<PlatformType> platformtype;

        public UnitOfWork(GameStoreContext db)
        {
            this.db = db;
        }
        public IRepository<Game> Game
        {
            get
            {
                if (game == null)
                    game = new Repository<Game>(this.db);
                return this.game;
            }
        }
        
        public IRepository<Comment> Comment
        {
            get
            {
                if (comment == null)
                    comment = new Repository<Comment>(this.db);
                return this.comment;
            }
        }
        public IRepository<Genre> Genre
        {
            get
            {
                if (genre == null)
                    genre = new Repository<Genre>(this.db);
                return this.genre;
            }
        }
        public IRepository<PlatformType> PlatformType
        {
            get
            {
                if (platformtype == null)
                    platformtype = new Repository<PlatformType>(this.db);
                return this.platformtype;
            }
        }
        public void Save()
        {
            this.db.SaveChanges();
        }
    }
}
