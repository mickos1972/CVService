using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DomainModels;
using CVService.Models;
using DAL;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CVService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        private readonly IGetContactDetailsBLL _bll;
        public ContactDetailsController(IGetContactDetailsBLL bll)
        {
            _bll = bll;
        }

        // GET: api/<CandidateController>
        [HttpGet]
        [Route("GetContactDetails")]
        public List<ContactDetailsViewModel> Get()
        {
            var result = _bll.getContactDetails();

            var mappedObjects = result.Select(x => mapFromDomain(x)).ToList();

            return mappedObjects;
        }

        // GET api/<CandidateController>/5
        //[HttpGet("{id}")]
        [HttpGet]
        [Route("GetContactDetailsById")]
        public ContactDetailsViewModel Get(int id)
        {
            //todo viewmodel with combo of contact, skill, list of workexperiences and a list of skills
            var result =  _bll.getContactDetailById(id);
            return mapFromDomain(result);
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        public static ContactDetailsViewModel mapFromDomain(ContactDomainModel source)
        {
            return new ContactDetailsViewModel
            {
                ContactId = source.ContactId,
                firstName = source.firstName,
                lastName = source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.street,
                postCode = source.postCode,
                SkillId = source.SkillId,
                Skill = source.Skill,
                WorkExperiences = source.WorkExperiences
            };
        }
    }
}
