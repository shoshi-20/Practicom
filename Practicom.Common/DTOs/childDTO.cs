using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicom.Common.DTOs
{
    public class ChildDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string ParentID { get; set; }
    }
}
