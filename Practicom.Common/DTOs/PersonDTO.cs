using Practicom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Common.DTOs
{
    public enum Egender { זכר = 1, נקבה = 2 }
    public enum EHMO { כללית = 1, מכבי = 2, מאוחדת = 4, לאומית = 8 }
    public class PersonDTO
    {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DOB { get; set; }
            public Egender Gender { get; set; }
            public EHMO HMO { get; set; }
            //public List<Child> Children { get; set; }

        }
    }
