using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
        private IGetSkillsBLL _skillBLL;
        private IPostSkillBLL _postSkillBLL;

        public SkillController(IGetSkillsBLL skillBLL, IPostSkillBLL postSkillBLL)
        {
            _skillBLL = skillBLL;
            _postSkillBLL = postSkillBLL;
        }

        //// GET: api/<SkillController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<SkillController>/5
        [HttpGet]
        [Route("GetSkillByContactDetails/{id}")]
        public SkillViewModel Get(int id)
        {
             var result = _skillBLL.getSkillsBLL(id);

             return MapFromDomain(result);
        }

        // POST api/<SkillController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost]
        [Route("PostSkillByContactDetails/{contactId}")]
        public void Post([FromBody] SkillViewModel value, int contactId)
        {
            var result = MapToDomain(value);

            _postSkillBLL.postSkillBLL(contactId, result);
        }

        //// PUT api/<SkillController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SkillController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        #region MyRegion

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
