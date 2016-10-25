using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL
{
    class GameStoreDbInitializer: DropCreateDatabaseIfModelChanges<GameStoreContext>
    {
        protected override void Seed(GameStoreContext db)
        {
            List<Comment> list=new List<Comment>
            {
                new Comment {Body="First comment",Name="Yaroslav",Comments=new List<Comment> {new Comment { Body="First subcomment",Name="Yaroslav"} } },
                new Comment {Body="Second comment",Name="Alexandr",Comments=new List<Comment> {new Comment { Body="Second comment",Name="Ivan"} } },
                new Comment {Body="Third comment",Name="Yulia" }
            };
            db.Comments.AddRange(list);
            db.SaveChanges();
            List<Genre> GenreList=new List<Genre>{
                new Genre{Name="Action",ParentId=null,Key="Action"},
                new Genre{Name="FPS",Key="FPS",ParentId="Action"},
                new Genre{Name="TPS",Key="TPS",ParentId="Action"},
                new Genre{Name="Misc",Key="Misc",ParentId="Action"}
            };
            db.Genres.AddRange(GenreList);
            db.SaveChanges();
            List<PlatformType> PlatformTypeList = new List<PlatformType>
            {
                new PlatformType{Name="PC"},
                new PlatformType{Name="Web"},
                new PlatformType{Name="Mobile"}
            };
            db.PlatformTypes.AddRange(PlatformTypeList);
            db.SaveChanges();
            List<Game> GameList = new List<Game>{
                new Game{Key="PC2132",Name="GTA 5",Description="GTA5 it's really cool game",Comments=list,Genre=new List<Genre>{GenreList[1]},PlatformType=new List<PlatformType>{PlatformTypeList[0],PlatformTypeList[1]}}
            };
            db.Games.AddRange(GameList);
            PlatformTypeList[0].Game = GameList;
            PlatformTypeList[1].Game = GameList;
            db.SaveChanges();
        }
    }
}


