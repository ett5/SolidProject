using Solid.Core.Repository;

using Solid.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data
{
    public class TasksRepsitory : ITasksRepository
    {
        private readonly DataContext _DataContext;
        public TasksRepsitory(DataContext dataContext)
        {
            _DataContext = dataContext;
        }
        public Tasks GetById(int id)
        {
            return _DataContext.TasksList.Find(id);
        }

        public List<Tasks> GetTasks()
        {
            return _DataContext.TasksList.ToList();

        }
        public async void DeleteAsync(Tasks Tasks)
        {  
             var t=GetById(Tasks.Id);
            if (t != null)
            {
                _DataContext.TasksList.Remove(t);

               await _DataContext.SaveChangesAsync();
            }


        }
        public async Task<Tasks> PutAsync(Tasks newTasks)

        {
            var t = GetById(newTasks.Id);
            if (t == null) { return null; };
            t.Job = newTasks.Job;
           t.Minute = newTasks.Minute;
            await _DataContext.SaveChangesAsync();
            return t; 

        }
        public async Task<Tasks> PostAsync(Tasks newTasks)
        {
            _DataContext.TasksList.Add(newTasks);
            await _DataContext.SaveChangesAsync();
            return newTasks;
        }

        

        
    }
}
