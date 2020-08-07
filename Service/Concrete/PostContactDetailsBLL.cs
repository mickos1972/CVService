using BLL.DomainModels;
using DAL;

namespace Service
{
    public class PostContactDetailsBLL : IPostContactDetailsBLL
    {
        private readonly IPostContactDetailsDAL _DAL;

        public PostContactDetailsBLL(IPostContactDetailsDAL DAL)
        {
            _DAL = DAL;
        }

        public void postContactDetailsBLL(ContactDomainModel contactDetails)
        {
            var mappedObject = MapToDALObject(contactDetails);

            _DAL.postContactDetails(mappedObject);
        }

        #region MyRegion

        private Contact MapToDALObject(ContactDomainModel source)
        {
            return new Contact
            {
                firstName = source.firstName,
                lastName= source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.city,
                postCode = source.postCode,
            };
        }

        #endregion
    }
}