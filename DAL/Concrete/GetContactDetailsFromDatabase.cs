using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GeContactDetailsFromDatabase : IGetContactDetailsFromDatabase
    {       
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
