using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.api.Models;
using Solid.Core.DTOs;
using Solid.Core.Service;


using Hours = Solid.Core.Entities.Hours;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoursController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHoursService _HoursService;
        public HoursController(IHoursService HoursService, IMapper mapper)
        {
            _HoursService = HoursService;
            _mapper = mapper;
        }

        // GET: api/<ValuesController1>
        [HttpGet]
        public List<HoursDTO> Get()
        {

            var list = _HoursService.GetHours();

            var listDto = _mapper.Map<IEnumerable<HoursDTO>>(list);
            return (List<HoursDTO>)listDto;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task PostAsync([FromBody] HoursPostModel newHours)
        {
            var newHoursToAdd = new Hours { Cost=newHours.Cost,Start=newHours.Start,End=newHours.End,EmployeeId=newHours.EmployeeId,TasksId=newHours.TasksId};
            var neww =await _HoursService.PostAsync(newHoursToAdd);
           _mapper.Map<HoursDTO>(neww);

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<HoursDTO> PutAsync(int id,[FromBody] HoursPostModel newHours)
        {
            var HoursToUpdate = _mapper.Map<Hours>(newHours);
            var updatedHours = await _HoursService.PutAsync(id,HoursToUpdate);
            return _mapper.Map<HoursDTO>(updatedHours);


        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id,cost}")]
        public async Task<HoursDTO> PutCostAsync(int id,[FromBody] HoursPostModel newHours)
        {
            var HoursToUpdate = new Hours { Cost = newHours.Cost };
            var updatedHours = await _HoursService.PutAsync(id,HoursToUpdate);
            return _mapper.Map<HoursDTO>(updatedHours);


          
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async void DeleteAsync(int id)
        {
             _HoursService.DeleteAsync(id);

        }

    }
}
