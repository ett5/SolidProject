using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.api.Models;
using Solid.Core.DTOs;
using Solid.Core.Service;


using Tasks = Solid.Core.Entities.Tasks;






// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiProject.Controllers
{
    [Route("apiProject/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ITasksService _TasksService;
        public TasksController(ITasksService TasksService, IMapper mapper)
        {
            _TasksService = TasksService;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<TasksDTO> Get()
        {
            var list = _TasksService.GetTasks();

            var listDto = _mapper.Map<IEnumerable<TasksDTO>>(list);
            return (List<TasksDTO>)listDto;

        }

       
        // POST api/<ValuesController>
        [HttpPost]
        public async Task PostAsync([FromBody] TasksPostModel newTasks)
        {
            var TasksToAdd = new Tasks { Minute = newTasks.Minute, Job = newTasks.Job };
            var neww =await _TasksService.PostAsync(TasksToAdd);
             _mapper.Map<TasksDTO>(neww);


        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<TasksDTO> PutAsync(int id,[FromBody] Tasks newTasks)

        {
            var TasksToUpdate = new Tasks { Minute = newTasks.Minute, Job = newTasks.Job };
            var updatedTasks = await  _TasksService.PutAsync( id,TasksToUpdate);
            return _mapper.Map<TasksDTO>(updatedTasks);


        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async void DeleteAsync(int id)
        {
            _TasksService.DeleteAsync(id);

        }
    }
}
