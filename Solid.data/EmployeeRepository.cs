using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repository;

namespace Solid.Data
{
    public class EmployeeRepository : IEmployeeRepository

    {
        private readonly DataContext _context;
        

        public EmployeeRepository(DataContext context)
        {
            _context = context;

        }
        public Employee GetById(int id)
        {
            return _context.EmployeeList.Find( id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.EmployeeList.ToList();


        }
       
        public async void DeleteAsync(int id )
        {
            var employee= GetById(id);
            if (employee != null)
            {
                _context.EmployeeList.Remove(employee);
               await _context.SaveChangesAsync();
            }


        }
        public async Task<Employee> PutAsync(Employee newEmployee)

        {
            var f=GetById(newEmployee.Id);
            if (f == null) { return null; };
            f.City = newEmployee.City;
            f.Name = newEmployee.Name;
            await _context.SaveChangesAsync();
            return newEmployee;

        }
        public async Task<Employee> PostAsync(Employee newEmployee)
        {
            _context.EmployeeList.Add(newEmployee);
            await _context.SaveChangesAsync();
            return newEmployee;

        }


    }
}
