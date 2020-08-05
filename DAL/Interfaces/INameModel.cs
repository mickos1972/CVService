using System.Collections.Generic;

namespace DAL
{
    public interface IGetNamesFromDatabaseINameModel
    {
        List<ContactDetails> GetAllNames();
        ContactDetails GetName(int id);
    }
}