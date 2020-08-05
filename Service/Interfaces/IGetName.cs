using System.Collections.Generic;
using DAL;

namespace Service
{
    public interface IGetContactDetailsBLL
    {
        object getCustomerDetail(int id);
        List<object> getCustomerDetails();
    }
}