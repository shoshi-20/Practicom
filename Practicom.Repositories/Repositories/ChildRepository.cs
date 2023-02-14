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
    public class ChildRepository:IChildRepository
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child c)
        {
            var c1 = _context.Children.Add(c);

            await _context.SaveChangesAsync();
            return c1.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child c)
        {
            Child c1 = await GetByIdAsync(c.Id);
            c1.Name = c.Name;
            c1.DOB = c.DOB;
            await _context.SaveChangesAsync();
            return c1;
        }

    }
}
