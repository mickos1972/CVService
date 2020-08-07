using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UpdateContactDetailsDAL : IUpdateContactDetailsDAL
    {
        public void updateContactDetailsDAL(Contact newContactDetails)
        {
            try
            {
                using var context = new CVContext();

                context.Update(newContactDetails);

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