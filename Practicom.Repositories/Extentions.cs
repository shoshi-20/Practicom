using Microsoft.Extensions.DependencyInjection;
using Practicom.Repositories.Interfaces;
using Practicom.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Repositories
{
   public static class Extentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
            return services;
        }
    }
}
