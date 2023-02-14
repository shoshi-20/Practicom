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
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService roleService)
        {
            _childService = roleService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(string id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildDTO c)
        {
            return await _childService.UpdateAsync(new ChildDTO()
            { Id = c.Id, Name = c.Name, DateOfBirth = c.DateOfBirth, ParentID = c.ParentID });
        }
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildDTO child)
        {
            ChildDTO c = await _childService.AddAsync(new ChildDTO()
            { Id = child.Id,Name = child.Name, DateOfBirth = child.DateOfBirth, ParentID = child.ParentID });
            return c;
        }
    }
}