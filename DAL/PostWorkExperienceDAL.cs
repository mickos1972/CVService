using System.Linq;
using DAL.Data;

namespace DAL
{
    public class PostWorkExperienceDAL : IPostWorkExperienceDAL
    {
        public void postContactDetailsDAL(WorkExperienceDAL workExperience)
        {
            using var context = new CVContext();

            context.Add(workExperience);

            context.SaveChanges();

            var contact = context.Contact.Single(x => x.ContactId == workExperience.ContactId);

            contact.WorkExperiences.Add(workExperience);

            context.Update(contact);

            context.SaveChanges();
        }
    }
}