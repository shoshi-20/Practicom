using Practicom.Common.DTOs;
using Practicom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egender = Practicom.Common.DTOs.Egender;
using EHMO = Practicom.Common.DTOs.EHMO;

namespace Practicom.Services.Interfaces
{
    public interface IPersonService
    {
        Task<List<PersonDTO>> GetAllAsync();

        Task<PersonDTO> GetByIdAsync(string id);

        Task<PersonDTO> AddAsync(PersonDTO person);

        Task<PersonDTO> UpdateAsync(PersonDTO person);

        Task DeleteAsync(string id);
    }
}
