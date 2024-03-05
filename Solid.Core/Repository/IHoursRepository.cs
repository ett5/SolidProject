using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
   public interface IHoursRepository
    {

        public Task<Hours> PutAsync(Hours newHours);
        public void DeleteAsync(int id);
        public Task<Hours> PostAsync(Hours newHours);
        public List<Hours> GetHours();

    }
}
