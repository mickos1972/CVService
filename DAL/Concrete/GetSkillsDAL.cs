using System;
using System.Linq;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GetSkillsDAL : IGetSkillsDAL
    {
        public Skills GetSkillById(int id)
        {
            try
            {
                using var context = new CVContext();

                return context.Skills.Single(x => x.SkillId == id);
            }
            catch (DbUpdateException e)
            {
                //this would be replaced with real logging
                Console.WriteLine(e.InnerException.Message);
                throw;
            }
        }

        public Skills GetSkillByContactId(int ContactId)
        {
            try
            {
                using var context = new CVContext();

                var result = context.Contact
                    .Include(c => c.Skill).Single(x => x.ContactId == ContactId).Skill;

                return result;
            }
            catch (DbUpdateException e)
            {
                //this would be replaced with real logging
                Console.WriteLine(e.InnerException.Message);
                throw;
            }
        }
    }
}