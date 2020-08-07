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

        public void postSkillBLL(int ContactId, SkillDomainModel skill)
        {
            var result = mapToDal(skill);

            _postSkillDAL.postSkillDAL(ContactId, result);
        }

        #region MyRegion

        private Skills mapToDal(SkillDomainModel source)
        {
            return new Skills
            {
                SkillId = source.SkillId,
                Description = source.Description
            };
        }

        #endregion
    }
}