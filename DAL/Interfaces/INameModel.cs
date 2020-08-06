using System.Collections.Generic;

namespace DAL
{
    public interface IGetNamesFromDatabaseINameModel
    {
        List<Contact> GetAllNames();
        Contact GetName(int id);
    }
}