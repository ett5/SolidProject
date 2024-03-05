using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EmployeeDTO
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public int Seniority { get; set; }


       

    }
}
