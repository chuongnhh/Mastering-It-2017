using DatabaseAccess;
using DatabaseObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLScore
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Score s)
        {
            db.Scores.Add(s);
            db.SaveChanges();
        }

        public void Update(Score s)
        {
            var score = Get(s.TeamId, s.LevelId, s.GameId);

            score.TeamId = s.TeamId;
            score.GameId = s.GameId;
            score.LevelId = s.LevelId;
            score.ScoreNumber = s.ScoreNumber;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var score = db.Scores.Find(Id);
            db.Scores.Remove(score);
            db.SaveChanges();
        }

        public List<Score> GetAll()
        {
            return db.Scores.ToList<Score>();
        }

        public Score Get(Guid Id)
        {
            return db.Scores.Find(Id);
        }

        public Score Get(Guid TeamId, Guid LevelId, Guid GameId)
        {
            return db.Scores.Where(x => x.TeamId == TeamId && x.LevelId == LevelId && x.GameId == GameId).FirstOrDefault<Score>();
        }

        public List<Score> GetByTeam(Guid TeamId)
        {
            return db.Scores.Where(x => x.TeamId == TeamId).ToList();
        }

    }
}
