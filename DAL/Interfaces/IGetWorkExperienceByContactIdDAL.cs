using System.Collections.Generic;

namespace DAL
{
    public interface IGetWorkExperienceByContactIdDAL
    {
        List<WorkExperienceDAL> getWorkExperienceByContactIdDAL(int contactId);
    }
}