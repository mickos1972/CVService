using BLL.DomainModels;
using DAL;

namespace Service
{
    public class GetSkillsBLL : IGetSkillsBLL
    {
        readonly IGetSkillsDAL _getSkillsDAL;

        public GetSkillsBLL(IGetSkillsDAL getSkillsDAL)
        {
            _getSkillsDAL = getSkillsDAL;
        }

        public SkillDomainModel getSkillsBLL(int contactId)
        {
            var result = _getSkillsDAL.GetSkillByContactId(contactId);

            return mapToDomain(result);
        }


        #region mapping

        private SkillDomainModel mapToDomain(Skills source)
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