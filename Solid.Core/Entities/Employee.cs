


namespace Solid.Core.Entities
{
    public class Employee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public int Seniority { get; set; }  


       public List<Hours> Hours { get; set; }  

    }
}