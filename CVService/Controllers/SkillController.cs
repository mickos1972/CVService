using BLL.DomainModels;
using CVService.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CVService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly IGetSkillsBLL _skillBLL;
        private readonly IPostSkillBLL _postSkillBLL;

        public SkillController(IGetSkillsBLL skillBLL, IPostSkillBLL postSkillBLL)
        {
            _skillBLL = skillBLL;
            _postSkillBLL = postSkillBLL;
        }

        // GET api/<SkillController>/5
        [HttpGet]
        [Route("GetSkillByContactDetailsId/{id}")]
        public SkillViewModel Get(int id)
        {
             var result = _skillBLL.getSkillsByIdBLL(id);

             return MapFromDomain(result);
        }

        [HttpPost]
        [Route("PostSkillByContactDetailsId/{contactId}")]
        public SkillViewModel Post([FromBody] SkillViewModel value, int contactId)
        {
            var result = MapToDomain(value);

            var newSkill = _postSkillBLL.postSkillBLL(contactId, result);

            return MapFromDomain(newSkill);
        }


        #region Mapping

        private static SkillViewModel MapFromDomain(SkillDomainModel source)
        {
            return new SkillViewModel
            {
                skillId = source.SkillId,
                description = source.Description
            };
        }

        private static SkillDomainModel MapToDomain(SkillViewModel source)
        {
            return new SkillDomainModel
            {
                SkillId = source.skillId,
                Description = source.description
            };
        }

        #endregion
    }
}
