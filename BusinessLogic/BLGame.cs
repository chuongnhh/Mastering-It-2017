using DatabaseAccess;
using DatabaseObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLGame
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Game g)
        {
            db.Games.Add(g);
            db.SaveChanges();
        }

        public void Update(Game g)
        {
            var game = db.Games.Find(g.Id);
            game.GameName = g.GameName;
            game.GameTime = g.GameTime;
            game.LevelId = g.LevelId;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var game = db.Games.Find(Id);
            db.Games.Remove(game);
            db.SaveChanges();
        }

        public List<Game> GetAll()
        {
            return db.Games.ToList<Game>();
        }

        public Game Get(Guid Id)
        {
            return db.Games.Find(Id);
        }
    }
}
