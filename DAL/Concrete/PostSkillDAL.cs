using DAL.Data;
using System.Linq;

namespace DAL
{
    public class PostSkillDAL : IPostSkillDAL
    {
        public void postSkillDAL(int contactDetailId, Skills source)
        {
            using var context = new CVContext();

            var contact = context.Contact.Single(x => x.ContactId == contactDetailId);

            context.Add(source);
            context.SaveChanges();

            contact.SkillId = source.SkillId;
            contact.Skill = contact.Skill;

            context.Update(contact);
            context.SaveChanges();
        }
    }
}