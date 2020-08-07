using System;
using BLL.DomainModels;
using DAL;

namespace Service
{
    public class PostWorkExperienceBLL : IPostWorkExperienceBLL
    {
        private readonly IPostWorkExperienceDAL _postWorkExperienceDAL;

        public PostWorkExperienceBLL(IPostWorkExperienceDAL postWorkExperienceDAL)
        {
            _postWorkExperienceDAL = postWorkExperienceDAL;
        }

        public void postWorkExperienceBLL(WorkExperienceDomainModel work)
        {
            var result = mapToDalModel(work);

            _postWorkExperienceDAL.postContactDetailsDAL(result);
        }

        #region mapping

        private WorkExperienceDAL mapToDalModel(WorkExperienceDomainModel source)
        {
            return new WorkExperienceDAL
            {
                Id = source.Id,
                from = source.from,
                to = source.to,
                duties = source.duties,
                ContactId = source.ContactId
            };
        }

        #endregion
    }
}