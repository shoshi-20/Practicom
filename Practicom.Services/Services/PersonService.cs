using AutoMapper;
using Practicom.Common.DTOs;
using Practicom.Repositories.Entities;
using Practicom.Repositories.Interfaces;
using Practicom.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egender = Practicom.Common.DTOs.Egender;
using EHMO = Practicom.Common.DTOs.EHMO;

namespace Practicom.Services.Services
{
    public class PersonService:IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<PersonDTO> AddAsync(PersonDTO person)
        {


            return _mapper.Map<PersonDTO>(await _personRepository.AddAsync(_mapper.Map<Person>(person)));
        }

        public async Task DeleteAsync(string id)
        {
            await _personRepository.DeleteAsync(id);
        }

        public async Task<List<PersonDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PersonDTO>>(await _personRepository.GetAllAsync());
        }

        public async Task<PersonDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<PersonDTO>(await _personRepository.GetByIdAsync(id));
        }

        public async Task<PersonDTO> UpdateAsync(PersonDTO person)
        {
            return _mapper.Map<PersonDTO>(await _personRepository.UpdateAsync(_mapper.Map<Person>(person)));

        }

    }
}
