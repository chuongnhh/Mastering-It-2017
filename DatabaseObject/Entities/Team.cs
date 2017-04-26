using CodeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseObject.Entities
{
    [Table("Team")]
    public class Team
    {
        public Team()
        {
            Id = GuidComb.GenerateComb();
            Members = new List<Member>();
            Scores = new List<Score>();
        }
        [Key]
        public Guid Id { get; set; }
        public string TeamName { get; set; }
        public int OrdeBy { get; set; }

        public virtual IList<Member> Members { get; set; }

        [ForeignKey("Level")]
        public Guid LevelId { get; set; }
        public virtual Level Level { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}
