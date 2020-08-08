using BLL.DomainModels;

namespace Service
{
    public interface IPostSkillBLL
    {
        SkillDomainModel postSkillBLL(int ContactId, SkillDomainModel skill);
    }
}