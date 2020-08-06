using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVService.Models;
using DAL;
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
        public List<NameView> Get()
        {
            var result = _bll.getContactDetails();
            return null;
        }

        // GET api/<CandidateController>/5
        //[HttpGet("{id}")]
        [HttpGet]
        [Route("GetContactDetailsById")]
        public NameView Get(int id)
        {
            //todo viewmodel with combo of contact, skill, list of workexperiences and a list of skills
            var result =  _bll.getContactDetailById(id);
            return null;
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
    }
}
