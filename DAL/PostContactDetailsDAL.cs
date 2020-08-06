using DAL.Data;

namespace DAL
{
    public class PostContactDetailsDAL : IPostContactDetailsDAL
    {
        public void postContactDetails(Contact newContactDetails)
        {
            using var context = new CVContext();

            context.Add(newContactDetails);

            context.SaveChanges();
        }
    }
}