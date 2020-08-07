using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GeContactDetailsFromDatabase : IGetContactDetailsFromDatabase
    {
        public GeContactDetailsFromDatabase()
        {
            //Some Initial setup data
            //using CVContext context = new CVContext();

            //var skill = new Skills()
            //{
            //    Description = "c++"
            //};

            //context.Add(skill);
            //context.SaveChanges();

            //var bobba = new Contact()
            //{
            //    firstName = "bobba",
            //    lastName = "fett",
            //    emailAddress = "bounter@hunters.com",
            //    SkillId = 1,
            //    WorkExperiences = new List<WorkExperienceDAL>()
            //};

            //context.Add(bobba);
            //context.SaveChanges();

            //var work = new WorkExperienceDAL()
            //{
            //    from = DateTime.Today,
            //    to = DateTime.Today.AddDays(6),
            //    duties = "hunting smugglers",
            //    ContactId = 1
            //};
            //context.Add(work);
            //context.SaveChanges();

            //var work2 = new WorkExperienceDAL()
            //{
            //    from = DateTime.Today,
            //    to = DateTime.Today.AddDays(3),
            //    duties = "looking cool",
            //    ContactId = 1
            //};
            //context.Add(work2);
            //context.SaveChanges();
        }

        public Contact getContactDetailsById(int id)
        {
            try
            {
                using var context = new CVContext();

                return context.Contact.Single(x => x.ContactId == id);
            }
            catch (DbUpdateException e)
            {
                //this would be replaced with real logging
                Console.WriteLine(e.InnerException.Message);
                throw;
            }
        }

        public List<Contact> getContactDetails()
        {
            try
            {
                using var context = new CVContext();

                var results = context.Contact.ToList();

                return results;
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
