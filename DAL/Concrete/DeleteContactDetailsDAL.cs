using DAL.Data;

namespace DAL
{
    public class DeleteContactDetailsDAL : IDeleteContactDetailsDAL
    {
        public void deleteContactDetailsDAL(int id)
        {
            using var context = new CVContext();

            var contact = new Contact { ContactId = id };

            context.Remove(contact);

            context.SaveChanges();
        }
    }
}