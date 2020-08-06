using BLL.DomainModels;
using DAL;

namespace Service
{
    public class UpdateContactDetailsBLL : IUpdateContactDetailsBLL
    {
        private readonly IUpdateContactDetailsDAL _DAL;

        public UpdateContactDetailsBLL(IUpdateContactDetailsDAL DAL)
        {
            _DAL = DAL;
        }

        public void updateContactDetailsBLL(ContactDomainModel contactDetails)
        {
            var mappedObject = MapToDALObject(contactDetails);

            _DAL.updateContactDetailsDAL(mappedObject);
        }

        #region MyRegion

        private Contact MapToDALObject(ContactDomainModel source)
        {
            return new Contact
            {
                ContactId = source.ContactId,
                firstName = source.firstName,
                lastName = source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.city,
                postCode = source.postCode,
                Skill = source.Skill,
                SkillId = source.SkillId == 0 ? null : source.SkillId
            };
        }

        #endregion
    }
}