using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace DAL
{
    public class ContactDetails
    {
        [Key]
        public int ContactsDetailsId { get; set; }
        
        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string emailAddress { get; set; }

        public string city { get; set; }
        public string street { get; set; }
        public string postCode { get; set; }
        public Skills skills { get; set; }

        public List<WorkExperience> workExperience { get; set; }
    }
}