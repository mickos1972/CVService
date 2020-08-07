using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace DAL
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string emailAddress { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string postCode { get; set; }
        public int? SkillId { get; set; }
        // this full row isn't stored in the db EF Core goes and fetches it
        public Skills Skill { get; set; }
        // has a corresponding ContactID in the WorkExperience object
        public List<WorkExperienceDAL> WorkExperiences { get; set; }
    }
}