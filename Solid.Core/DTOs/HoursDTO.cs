using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class HoursDTO
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public float Cost { get; set; }
        public int EmployeeId { get; set; }

        public int TasksId { get; set; }
        //public Employee Employee { get; set; }     
        //public Tasks Tasks { get; set; }

    }
}
