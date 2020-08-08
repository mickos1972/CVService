using BLL.DomainModels;

namespace Service
{
    public interface IGetSkillsBLL
    {
        SkillDomainModel getSkillsByIdBLL(int contactId);
    }
}