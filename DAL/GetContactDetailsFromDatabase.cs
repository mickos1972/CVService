using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DAL.Data;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GeContactDetailsFromDatabase : IGetContactDetailsFromDatabase
    {
        public GeContactDetailsFromDatabase()
        {
            ////Some Initial setup data
            //using CVContext context = new CVContext();
            //Skills skill = new Skills()
            //{
            //    Description = "I can do loads get me!"
            //};
            //context.Add(skill);
            //context.SaveChanges();

            //Contact tracy = new Contact()
            //{
            //    firstName = "test55",
            //    lastName = "ball",
            //    emailAddress = "emailAddress4",
            //    SkillId = 1,
            //    WorkExperiences = new List<WorkExperience>()
            //};
            //context.Add(tracy);
            //context.SaveChanges();

            //WorkExperience wok = new WorkExperience()
            //{
            //    from = DateTime.Today,
            //    to = DateTime.Today.AddDays(6),
            //    duties = "slacking off",
            //    ContactId = 1
            //};
            //context.Add(wok);
            //context.SaveChanges();
            //WorkExperience wok2 = new WorkExperience()
            //{
            //    from = DateTime.Today,
            //    to = DateTime.Today.AddDays(3),
            //    duties = "slacking off2",
            //    ContactId = 1
            //};
            //context.Add(wok2);
            //context.SaveChanges();
        }

        public Contact getContactDetailsById(int id)
        {
            using CVContext context = new CVContext();

            //var result  = context.Contact
            //    .Include(c => c.Skill)
            //    .Include(v => v.WorkExperiences)
            //    .Single(x => x.ContactId == id);

            return context.Contact.Single(x => x.ContactId == id);
        }

        public List<Contact> getContactDetails()
        {
            using CVContext context = new CVContext();

            var results = context.Contact.ToList();

            return results;
        }
    }
}
