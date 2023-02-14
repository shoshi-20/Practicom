using Practicom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();

        Task<Person> GetByIdAsync(string id);

        Task<Person> AddAsync(Person p);
        Task<Person> UpdateAsync(Person p);
        Task DeleteAsync(string id);
    }
}
