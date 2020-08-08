using BLL.DomainModels;

namespace Service
{
    public interface IPostContactDetailsBLL
    {
        ContactDomainModel postContactDetailsBLL(ContactDomainModel contactDetails);
    }
}