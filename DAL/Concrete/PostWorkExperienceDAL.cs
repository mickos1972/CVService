using System;
using System.Linq;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PostWorkExperienceDAL : IPostWorkExperienceDAL
    {
        public void postContactDetailsDAL(WorkExperienceDAL workExperience)
        {
            try
            {
                using var context = new CVContext();

                context.Add(workExperience);

                context.SaveChanges();

                var contact = context.Contact.Single(x => x.ContactId == workExperience.ContactId);

                contact.WorkExperiences.Add(workExperience);

                context.Update(contact);

                context.SaveChanges();
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