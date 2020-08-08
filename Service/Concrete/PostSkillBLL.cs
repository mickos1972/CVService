using BLL.DomainModels;
using DAL;

namespace Service
{
    public class PostSkillBLL : IPostSkillBLL
    {
        private IPostSkillDAL _postSkillDAL;

        public PostSkillBLL(IPostSkillDAL postSkillDAL)
        {
            _postSkillDAL = postSkillDAL;
        }

        public SkillDomainModel postSkillBLL(int ContactId, SkillDomainModel skill)
        {
            var result = mapToDal(skill);

            var newSkill = _postSkillDAL.postSkillDAL(ContactId, result);

            return mapFromDal(newSkill);
        }

        #region mapping

        private Skills mapToDal(SkillDomainModel source)
        {
            return new Skills
            {
                SkillId = source.SkillId,
                Description = source.Description
            };
        }

        private SkillDomainModel mapFromDal(Skills source)
        {
            return new SkillDomainModel
            {
                SkillId = source.SkillId,
                Description = source.Description
            };
        }

        #endregion
    }
}