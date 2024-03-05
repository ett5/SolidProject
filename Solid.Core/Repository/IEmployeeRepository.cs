using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
   public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();
        public void DeleteAsync(int id);

        public Task<Employee> PutAsync(Employee newEmployee);
        public Task<Employee> PostAsync(Employee newEmployee);


    }
}
