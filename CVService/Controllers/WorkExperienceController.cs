using System.Collections.Generic;
using System.Linq;
using BLL.DomainModels;
using CVService.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CVService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        private readonly IPostWorkExperienceBLL _postWorkExperienceBll;
        private readonly IGetWorkExperienceByContactIdBLL _getWorkExperienceByContactId;

        public WorkExperienceController(IPostWorkExperienceBLL postWorkExperienceBll, IGetWorkExperienceByContactIdBLL getWorkExperienceByContactId)
        {
            _postWorkExperienceBll = postWorkExperienceBll;
            _getWorkExperienceByContactId = getWorkExperienceByContactId;
        }

        // GET api/<WorkExperienceController>/5
        [HttpGet]
        [Route("GetWorkExperienceByContactId/{id}")]
        public List<WorkExperienceViewModel> Get(int id)
        {
            var result = _getWorkExperienceByContactId.getWorkExperienceByContactIdBLL(id);

            return result.Select(mapFromDomain).ToList();
        }

        // POST api/<WorkExperienceController>
        [HttpPost]
        [Route("PostWorkExperienceByContactId")]
        public WorkExperienceViewModel Post([FromBody] WorkExperienceViewModel workExperience)
        {
            var result = mapToDomain(workExperience);

            var newWorkExerience = _postWorkExperienceBll.postWorkExperienceBLL(result);

            return mapFromDomain(newWorkExerience);
        }

        #region mappings

        private static WorkExperienceDomainModel mapToDomain(WorkExperienceViewModel source)
        {
            return new WorkExperienceDomainModel
            {
                Id = source.Id,
                from = source.from,
                to = source.to,
                duties = source.duties,
                ContactId = source.ContactId
            };
        }

        private static WorkExperienceViewModel mapFromDomain(WorkExperienceDomainModel source)
        {
            return new WorkExperienceViewModel
            {
                Id = source.Id,
                from = source.from,
                to = source.to,
                duties = source.duties,
                ContactId = source.ContactId
            };
        }

        #endregion
    }
}
