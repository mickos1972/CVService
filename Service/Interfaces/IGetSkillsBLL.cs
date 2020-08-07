using BLL.DomainModels;

namespace Service
{
    public interface IGetSkillsBLL
    {
        SkillDomainModel getSkillsBLL(int contactId);
    }
}