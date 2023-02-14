using Microsoft.EntityFrameworkCore;
using Practicom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Repositories.Interfaces
{
    public interface IContext
    {
         DbSet<Person> Persons { get; set; }
         DbSet<Child> Children { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
