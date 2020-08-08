using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PostContactDetailsDAL : IPostContactDetailsDAL
    {
        public Contact postContactDetails(Contact newContactDetails)
        {
            try
            {
                using var context = new CVContext();

                context.Add(newContactDetails);

                context.SaveChanges();

                return newContactDetails;
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