using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Service;

namespace Solid.Service
{
public class TasksService:ITasksService
    {
        private readonly ITasksRepository _TasksRepository;
        public TasksService(ITasksRepository TasksRepository)
        {
            _TasksRepository = TasksRepository;
        }
        public List<Tasks> GetTasks()
        {
            return _TasksRepository.GetTasks();

        }
        public async void  DeleteAsync(int id)
        {

            var f = _TasksRepository.GetTasks().Find(x => x.Id == id);
            if (f == null)
                return ;
            _TasksRepository.DeleteAsync(f);
            
        }
       
        public async Task<Tasks> PutAsync(int id,Tasks newTasks)
        {
            if (newTasks == null)
                return null;
  newTasks.Id = id;
           return await _TasksRepository.PutAsync(newTasks);
           
        }
        public async Task<Tasks> PostAsync(Tasks newTasks)

        {
            if (newTasks == null)
                return null;
          
           return  await _TasksRepository.PostAsync(newTasks);
        }

        
    }
}

