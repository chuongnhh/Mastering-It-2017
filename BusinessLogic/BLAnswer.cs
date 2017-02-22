using DatabaseAccess;
using DatabaseObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLAnswer
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Answer a)
        {
            db.Answers.Add(a);
            db.SaveChanges();
        }

        public void Update(Answer a)
        {
            var answer = db.Answers.Find(a.Id);
            answer.AnswerLeter = a.AnswerLeter;
            answer.AnswerName = a.AnswerName;
            answer.IsTrue = a.IsTrue;
            answer.QuestionId = a.QuestionId;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var answer = db.Answers.Find(Id);
            db.Answers.Remove(answer);
            db.SaveChanges();
        }

        public List<Answer> GetAll()
        {
            return db.Answers.ToList<Answer>();
        }

        public Answer Get(Guid Id)
        {
            return db.Answers.Find(Id);
        }
    }
}
