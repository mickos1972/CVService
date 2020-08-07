using BLL.DomainModels;

namespace Service
{
    public interface IPostSkillBLL
    {
        void postSkillBLL(int ContactId, SkillDomainModel skill);
    }
}