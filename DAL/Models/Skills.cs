using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Skills
    {
        public int Id { get; set; }
        public string skills { get; set; }

        [ForeignKey("ContactsDetailsId")]
        public int ContactsDetailsId { get; set; }
        public ContactDetails ContactDetails { get; set; }
    }
}