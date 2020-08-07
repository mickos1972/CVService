using System.Collections.Generic;
using System.Linq;
using BLL.DomainModels;
using DAL;

namespace Service
{
    public class GetWorkExperienceByContactIdBLL : IGetWorkExperienceByContactIdBLL
    {
        private IGetWorkExperienceByContactIdDAL _getWorkExperienceByContactIdDAL;

        public GetWorkExperienceByContactIdBLL(IGetWorkExperienceByContactIdDAL getWorkExperienceByContactIdDAL)
        {
            _getWorkExperienceByContactIdDAL = getWorkExperienceByContactIdDAL;
        }

        public List<WorkExperienceDomainModel> getWorkExperienceByContactIdBLL(int id)
        {
            var result = _getWorkExperienceByContactIdDAL.getWorkExperienceByContactIdDAL(id);

            return result.Select(mapFromDal).ToList();
        }

        #region mapping

        private WorkExperienceDomainModel mapFromDal(WorkExperienceDAL source)
        {
            return new WorkExperienceDomainModel()
            {
                Id = source.Id,
                from = source.from,
                to = source.to,
                duties = source.duties,
                ContactId= source.ContactId
            };
        }

        #endregion
    }
}