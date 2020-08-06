using System;
using System.Collections.Generic;
using System.Linq;
using BLL.DomainModels;
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

        public ContactDomainModel getContactDetailById(int id)
        {
            var result = _getNamesDAL.getContactDetailsById(id);

            return mapResultsFromDAL(result);
        }

        public List<ContactDomainModel> getContactDetails()
        {
            var result = _getNamesDAL.getContactDetails();

            return result.Select(mapResultsFromDAL).ToList();
        }


        public ContactDomainModel mapResultsFromDAL(Contact source)
        {
            return new ContactDomainModel
            {
                ContactId = source.ContactId,
                firstName = source.firstName,
                lastName = source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.street,
                postCode = source.postCode,
                SkillId = source.SkillId,
                Skill = source.Skill,
                WorkExperiences = source.WorkExperiences
            };
        }
    }
}
