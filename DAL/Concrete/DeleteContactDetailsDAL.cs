using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DeleteContactDetailsDAL : IDeleteContactDetailsDAL
    {
        public void deleteContactDetailsDAL(int id)
        {
            try
            {
                using var context = new CVContext();

                var contact = new Contact { ContactId = id };

                context.Remove(contact);

                context.SaveChanges();
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