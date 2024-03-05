using Solid.Core.Entities;

namespace Solid.Core.Repository
{
    public interface ITasksRepository
    {

        public List<Tasks> GetTasks();
        public Task<Tasks> PostAsync(Tasks newTasks);
        public Task<Tasks> PutAsync(Tasks newTasks);
        public void DeleteAsync(Tasks Tasks);
    }
}
