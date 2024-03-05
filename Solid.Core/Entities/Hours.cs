

namespace Solid.Core.Entities;
public class Hours


{
    

    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public float Cost { get; set; }
 
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public int TasksId { get; set; }
    public Tasks Tasks { get; set; }
   
    
}

