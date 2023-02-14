using AutoMapper;
using Practicom.Common.DTOs;
using Practicom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
        }
    }
}
