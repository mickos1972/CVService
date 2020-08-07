using System;
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
            try
            {
                using var context = new CVContext();

                var result = context.WorkExperiences.Where(x => x.ContactId == contactId).ToList();

                return result;
            }
            catch (DbUpdateException e)
            {
                //this would be replaced with real logging
                Console.WriteLine(e);
                throw;
            }
        }
    }
}