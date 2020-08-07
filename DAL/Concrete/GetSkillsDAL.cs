using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GetSkillsDAL : IGetSkillsDAL
    {
        public Skills GetSkillById(int id)
        {
            using var context = new CVContext();

            //var result  = context.Contact
            //    .Include(c => c.Skill)
            //    .Include(v => v.WorkExperiences)
            //    .Single(x => x.ContactId == id);

            return context.Skills.Single(x => x.SkillId == id);
        }

        public Skills GetSkillByContactId(int ContactId)
        {
            using var context = new CVContext();

            var result = context.Contact
                .Include(c => c.Skill).Single(x => x.ContactId == ContactId).Skill;

            return result;
        }
    }
}