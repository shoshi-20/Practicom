using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practicom.Common.DTOs;
using Practicom.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicom.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {

            _personService = personService;
        }
        [HttpGet]
        public async Task<List<PersonDTO>> Get()
        {
            return await _personService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonDTO> Get(string id)
        {
            return await _personService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _personService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<PersonDTO> Update([FromBody] PersonDTO p)
        {
            return await _personService.UpdateAsync(new PersonDTO()
            { Id = p.Id, FirstName = p.FirstName, LastName = p.LastName, HMO = p.HMO, Gender = p.Gender, DOB = p.DOB });
        }
        [HttpPost]
        public async Task<PersonDTO> Post([FromBody] PersonDTO person)
        {
            PersonDTO p = await _personService.AddAsync(new PersonDTO()
            { Id = person.Id, FirstName = person.FirstName, LastName = person.LastName, HMO = person.HMO, Gender = person.Gender, DOB = person.DOB });
            return p;
        }
    }
}
