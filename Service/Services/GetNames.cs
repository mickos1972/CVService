using System;
using System.Collections.Generic;
using DAL;

namespace Service
{
    public class GetContactDetailsBLL : IGetContactDetailsBLL
    {
        IGetContactDetailsFromDatabase _getNamesDAL;

        public GetContactDetailsBLL(IGetContactDetailsFromDatabase getNamesDAL)
        {
            _getNamesDAL = getNamesDAL;
        }
        

        public object getContactDetailsById(int id)
        {
            var result = _getNamesDAL.getContactDetailsById(id);
            return null;
        }

        public List<object> getContactDetails()
        {
            var result = _getNamesDAL.getContactDetails();


            return null;
        }
    }
}
