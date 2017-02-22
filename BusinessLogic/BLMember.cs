using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;
using DatabaseObject.Entities;

namespace BusinessLogic
{
    public class BLMember
    {
        private MasteringItDbContext db = new MasteringItDbContext();

        public void Insert(Member m)
        {
            db.Members.Add(m);
            db.SaveChanges();
        }

        public void Update(Member m)
        {
            var member = db.Members.Find(m.Id);
            member.MemberName = m.MemberName;
            member.StudentCode = m.StudentCode;
            member.PhoneNumber = m.PhoneNumber;
            member.TeamId = m.TeamId;

            db.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            var member = db.Members.Find(Id);
            db.Members.Remove(member);
            db.SaveChanges();
        }

        public List<Member> GetAll()
        {
            return db.Members.ToList<Member>();
        }

        public Member Get(Guid Id)
        {
            return db.Members.Find(Id);
        }
    }
}
