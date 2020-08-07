using DAL.Data;

namespace DAL
{
    public class UpdateContactDetailsDAL : IUpdateContactDetailsDAL
    {
        public void updateContactDetailsDAL(Contact newContactDetails)
        {
            using var context = new CVContext();

            context.Update(newContactDetails);

            context.SaveChanges();
        }
    }
}