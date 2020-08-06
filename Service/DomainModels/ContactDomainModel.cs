using System.Collections.Generic;
using DAL;

namespace BLL.DomainModels
{
    public class ContactDomainModel
    {
        public int ContactId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string postCode { get; set; }
        public int? SkillId { get; set; }
        public Skills Skill { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
    }
}