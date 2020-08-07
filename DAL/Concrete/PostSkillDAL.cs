using System;
using DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PostSkillDAL : IPostSkillDAL
    {
        public void postSkillDAL(int contactDetailId, Skills source)
        {
            try
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
            catch (DbUpdateException e)
            {
                //this would be replaced with real logging
                Console.WriteLine(e);
                throw;
            }
        }
    }
}