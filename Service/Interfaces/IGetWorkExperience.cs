using System.Collections.Generic;
using BLL.DomainModels;

namespace Service
{
    public interface IGetWorkExperienceByContactIdBLL
    {
        List<WorkExperienceDomainModel> getWorkExperienceByContactIdBLL(int id);
    }
}