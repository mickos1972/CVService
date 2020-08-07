using System;

namespace CVService.Models
{
    public class WorkExperienceViewModel
    {
        public int Id { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public string duties { get; set; }
        public int ContactId { get; set; }
    }
}