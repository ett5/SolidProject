using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.api.Models;
using Solid.Core.DTOs;
using Solid.Core.Service;
using Solid.Service;
using Employee = Solid.Core.Entities.Employee;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiProject.Controllers
{
    [Route("apiProject/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService EmployeeService, IMapper mapper)
        {
            _EmployeeService = EmployeeService;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<EmployeeDTO> Get()
        {
            var list = _EmployeeService.GetEmployees();

            var listDto = _mapper.Map<IEnumerable<EmployeeDTO>>(list);
            return listDto as List<EmployeeDTO>;
 
        }

        // GET api/<ValuesController>/5
        //[HttpGet("{city}")]
        // public IEnumerable<Employee> Get(string city)
        ///{
        //  List<Employee> EmployeeCity = new List<Employee>;
        // return "value";
        //}

        // POST api/<ValuesController>
        [HttpPost]
        public async void PostAsync( [FromBody] EmployeePostModel newEmployee) { 
            var  EmployeeToAdd  = new Employee { Name = newEmployee.Name, City = newEmployee.City, BirthDate = newEmployee.BirthDate, Seniority = newEmployee.Seniority };

            var neww = await _EmployeeService.PostAsync(EmployeeToAdd);
             _mapper.Map<EmployeeDTO>(neww);
        
          
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<EmployeeDTO> PutAsync( int id ,[FromBody] EmployeePostModel newEmployee)

        {
            var EmployeeToUpdate = new Employee { Name = newEmployee.Name ,City=newEmployee.City,BirthDate=newEmployee.BirthDate, Seniority =newEmployee.Seniority };
        var updatedEmployee =  await _EmployeeService.PutAsync(id,EmployeeToUpdate);
            return _mapper.Map<EmployeeDTO>(updatedEmployee);

    
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async void DeleteAsync(int id)
        {
             _EmployeeService.DeleteAsync(id);
        
        }
    }
}
