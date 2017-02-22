using DatabaseAccess;
using DatabaseObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLTeam
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Team t)
        {
            db.Teams.Add(t);
            db.SaveChanges();
        }

        public void Update(Team t)
        {
            var team = db.Teams.Find(t.Id);
            team.TeamName = t.TeamName;
            team.LevelId = t.LevelId;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var team = db.Teams.Find(Id);
            db.Teams.Remove(team);
            db.SaveChanges();
        }

        public List<Team> GetAll()
        {
            return db.Teams.ToList<Team>();
        }

        public Team Get(Guid Id)
        {
            return db.Teams.Find(Id);
        }
    }
}
