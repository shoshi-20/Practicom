using Microsoft.Extensions.DependencyInjection;
using Practicom.Repositories;
using Practicom.Services.Interfaces;
using Practicom.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Services
{
  public static  class Extentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IChildService, ChildService>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
