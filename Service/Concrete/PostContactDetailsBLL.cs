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

        public ContactDomainModel postContactDetailsBLL(ContactDomainModel contactDetails)
        {
            var mappedObject = MapToDALObject(contactDetails);

            var result = _DAL.postContactDetails(mappedObject);

            return MapFromDALObject(result);
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

        private ContactDomainModel MapFromDALObject(Contact source)
        {
            return new ContactDomainModel
            {
                ContactId = source.ContactId,
                firstName = source.firstName,
                lastName = source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.city,
                postCode = source.postCode,
            };
        }



        #endregion
    }
}