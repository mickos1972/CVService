﻿using System;
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
        private readonly IGetContactDetailsBLL _getContactDetailsBLL;
        private readonly IPostContactDetailsBLL _postContactDetailsBLL;
        private readonly IUpdateContactDetailsBLL _updateContactDetailsBLL;
        public ContactDetailsController(IGetContactDetailsBLL getContactDetailsBLL, IPostContactDetailsBLL postContactDetailsBLL, IUpdateContactDetailsBLL updateContactDetailsBLL)
        {
            _getContactDetailsBLL = getContactDetailsBLL;
            _postContactDetailsBLL = postContactDetailsBLL;
            _updateContactDetailsBLL = updateContactDetailsBLL;
        }

        // GET: api/<CandidateController>
        [HttpGet]
        [Route("GetContactDetails")]
        public List<ContactDetailsViewModel> Get()
        {
            var result = _getContactDetailsBLL.getContactDetails();

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
            var result =  _getContactDetailsBLL.getContactDetailById(id);
            return mapFromDomain(result);
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post([FromBody] ContactDetailsViewModel value)
        {
            _postContactDetailsBLL.postContactDetailsBLL(mapToDomain(value));
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ContactDetailsViewModel value)
        {
            _updateContactDetailsBLL.updateContactDetailsBLL(mapToDomain(value, id));
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        #region mapping

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

        public static ContactDomainModel mapToDomain(ContactDetailsViewModel source)
        {
            return new ContactDomainModel
            {
                ContactId = source.ContactId,
                firstName = source.firstName,
                lastName = source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.street,
                postCode = source.postCode,
                SkillId = source.SkillId == 0 ? null : source.SkillId,
                Skill = source.Skill,
                WorkExperiences = source.WorkExperiences
            };
        }

        public static ContactDomainModel mapToDomain(ContactDetailsViewModel source, int id)
        {
            return new ContactDomainModel
            {
                ContactId = id,
                firstName = source.firstName,
                lastName = source.lastName,
                emailAddress = source.emailAddress,
                city = source.city,
                street = source.street,
                postCode = source.postCode,
                SkillId = source.SkillId == 0 ? null : source.SkillId,
                Skill = source.Skill,
                WorkExperiences = source.WorkExperiences
            };
        }

        #endregion
    }
}
