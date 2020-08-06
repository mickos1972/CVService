using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Skills
    {
        [Key]
        //[ForeignKey("SkillId")]
        public int SkillId { get; set; }
        public string Description { get; set; }

        //[ForeignKey("ContactsDetailsId")]
        ////public int ContactsDetailsId { get; set; }
        //public ContactDetails ContactDetails { get; set; }
    }
}