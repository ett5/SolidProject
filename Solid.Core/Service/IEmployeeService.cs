using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IEmployeeService
    {
        public  Task<Employee> PostAsync( Employee newEmployee);
        public Task<Employee> PutAsync(int id, Employee newEmployee);
        public void DeleteAsync(int id);
        public List<Employee> GetEmployees();

    }
}
