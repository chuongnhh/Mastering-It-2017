using DatabaseAccess;
using DatabaseObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLQuestion
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Question q)
        {
            db.Questions.Add(q);
            db.SaveChanges();
        }

        public void Update(Question q)
        {
            var question = db.Questions.Find(q.Id);
            question.QuestionName = q.QuestionName;
            question.GameId = q.GameId;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var question = db.Questions.Find(Id);
            db.Questions.Remove(question);
            db.SaveChanges();
        }

        public List<Question> GetAll()
        {
            return db.Questions.ToList<Question>();
        }

        public Question Get(Guid Id)
        {
            return db.Questions.Find(Id);
        }
    }
}
