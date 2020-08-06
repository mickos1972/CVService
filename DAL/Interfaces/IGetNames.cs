using System.Collections.Generic;

namespace DAL
{
    public interface IGetContactDetailsFromDatabase
    {
        Contact getContactDetailsById(int id);
        List<Contact> getContactDetails();
    }
}