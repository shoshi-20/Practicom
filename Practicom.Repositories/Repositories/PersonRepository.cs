using Microsoft.EntityFrameworkCore;
using Practicom.Repositories.Entities;
using Practicom.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Repositories.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IContext _context;

        public PersonRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Person> AddAsync(Person p)
        {
            var p1 = _context.Persons.Add(p);

            await _context.SaveChangesAsync();
            return p1.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            _context.Persons.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(string id)
        {
            return await _context.Persons.FindAsync(id);
        }

        public async Task<Person> UpdateAsync(Person p)
        {
            Person p1 = await GetByIdAsync(p.Id);
            p1.FirstName = p.FirstName;
            p1.LastName = p.LastName;
            p1.DOB = p.DOB;
            p1.Gender = p.Gender;
            p1.HMO = p.HMO;
            await _context.SaveChangesAsync();
            return p1;
        }
    }
}
