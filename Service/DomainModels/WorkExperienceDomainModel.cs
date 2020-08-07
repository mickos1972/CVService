using System;

namespace BLL.DomainModels
{
    public class WorkExperienceDomainModel
    {
        public int Id { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public string duties { get; set; }
        public int ContactId { get; set; }
    }
}