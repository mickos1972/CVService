using System.Collections.Generic;
using BLL.DomainModels;
using DAL;

namespace Service
{
    public interface IGetContactDetailsBLL
    {
        ContactDomainModel getContactDetailById(int id);
        List<ContactDomainModel> getContactDetails();
    }
}