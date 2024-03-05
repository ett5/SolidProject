using Solid.Core.Entities;

namespace Solid.api.Models
{
    public class HoursPostModel
    {

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public float Cost { get; set; }

        public int EmployeeId { get; set; }
        
        public int TasksId { get; set; }
       

    }
}
