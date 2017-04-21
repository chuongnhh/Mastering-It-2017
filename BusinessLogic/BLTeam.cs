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

        public List<Team> GetByLevel(Guid LevelId, Guid gameId)
        {
            int teamNumber = db.Games.Find(gameId).TeamNumber;

            return db.Teams.OrderByDescending(x => x.Scores.Max(z => z.ScoreNumber))
                .Where(x => x.LevelId == LevelId).Take(teamNumber)
                .ToList<Team>();
        }

        public List<Team> GetByLevel(Guid LevelId)
        {

            return db.Teams
                .Where(x => x.LevelId == LevelId)
                .ToList<Team>();
        }
    }
}
