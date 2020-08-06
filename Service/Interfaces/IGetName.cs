using System.Collections.Generic;
using DAL;

namespace Service
{
    public interface IGetContactDetailsBLL
    {
        object getContactDetailsById(int id);
        List<object> getContactDetails();
    }
}