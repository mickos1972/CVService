using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GetNamesFromDatabase : IGetNamesFromDatabase
    {
    public GetNamesFromDatabase()
        {
            //Some Initial setup data
            using CVContext context = new CVContext();

            ContactDetails tracy = new ContactDetails()
            {
                firstName = "test55",
                lastName = "ball",
                emailAddress = "emailAddress4",
                skills = new Skills() { skills = "i can do even loads" },
                workExperience = new List<WorkExperience>() { new WorkExperience() {duties = "loads"}}
            };

            //context.Add(tracy);

            //ContactDetails steve = new ContactDetails()
            //{
            //    firstName = "steve",
            //    lastName = "bollsover",
            //    emailAddress = "emailAddress5"
            //};

            context.Add(tracy);

            context.SaveChanges();
        }

        public ContactDetails getName(int id)
        {
            using CVContext context = new CVContext();

            var result  = context.ContactDetails.Single(x => x.ContactsDetailsId == id);

            var skill = result.skills;

            return null;
            //return result;
        }

        public List<ContactDetails> getNames()
        {
            using CVContext context = new CVContext();


            var results = context.ContactDetails.ToList();

            return results;
        }
    }
}
