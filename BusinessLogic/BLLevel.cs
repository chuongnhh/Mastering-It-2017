using DatabaseAccess;
using DatabaseObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLLevel
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Level l)
        {
            db.Levels.Add(l);
            db.SaveChanges();
        }

        public void Update(Level l)
        {
            var level = db.Levels.Find(l.Id);
            level.LevelName = l.LevelName;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var level = db.Levels.Find(Id);
            db.Levels.Remove(level);
            db.SaveChanges();
        }

        public List<Level> GetAll()
        {
            return db.Levels.ToList<Level>();
        }

        public Level Get(Guid Id)
        {
            return db.Levels.Find(Id);
        }
    }
}
