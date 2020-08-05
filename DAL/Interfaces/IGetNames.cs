using System.Collections.Generic;

namespace DAL
{
    public interface IGetNamesFromDatabase
    {
        ContactDetails getName(int id);
        List<ContactDetails> getNames();
    }
}