using System.Collections.Generic;
using System.Linq;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GetWorkExperienceByContactIdDAL : IGetWorkExperienceByContactIdDAL
    {
        public List<WorkExperienceDAL> getWorkExperienceByContactIdDAL(int contactId)
        {
            using var context = new CVContext();

            var result = context.WorkExperiences.Where(x => x.ContactId == contactId).ToList();

            return result;
        }
    }
}