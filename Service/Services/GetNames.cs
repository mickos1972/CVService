using System;
using System.Collections.Generic;
using DAL;

namespace Service
{
    public class GetContactDetailsBLL : IGetContactDetailsBLL
    {
        IGetNamesFromDatabase _getNamesDAL;

        public GetContactDetailsBLL(IGetNamesFromDatabase getNamesDAL)
        {
            _getNamesDAL = getNamesDAL;
        }
        

        public object getCustomerDetail(int id)
        {
            var result = _getNamesDAL.getName(id);
            return null;
        }

        public List<object> getCustomerDetails()
        {
            var result = _getNamesDAL.getNames();


            return null;
        }
    }
}
