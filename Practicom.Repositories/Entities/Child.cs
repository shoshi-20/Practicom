using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Repositories.Entities
{
    public class Child
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ParentID { get; set; }
    }
}
