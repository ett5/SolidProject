
using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Service;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class EmployeeService : IEmployeeService
            
    {
         static int count = 1;
        private readonly IEmployeeRepository _EmployeeRepository;
        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }
        public List<Employee> GetEmployees()
        {
            return _EmployeeRepository.GetEmployees();

        }
        public async void DeleteAsync(int id)
        {
            
          
        
            _EmployeeRepository.DeleteAsync(id);
    
        }
        public async Task<Employee> PutAsync(int id,Employee newEmployee)
        {


            if (newEmployee == null)
                return null;
            newEmployee.Id = id;
            return    await _EmployeeRepository.PutAsync(newEmployee);
          
        }
        public async Task<Employee> PostAsync( Employee newEmployee)
            
        {
            if (newEmployee ==null)
                return null;
            return await _EmployeeRepository.PostAsync(newEmployee);
        }
    }
}
