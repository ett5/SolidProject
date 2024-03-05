using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
   public interface ITasksService
    {
   
        public Task<Tasks> PostAsync(Tasks newTasks);
        public Task<Tasks> PutAsync( int id,Tasks newTasks);
        public void DeleteAsync(int id);
        public List<Tasks> GetTasks();

    }
}
