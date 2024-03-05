using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IHoursService
    {
        public Task<Hours> PostAsync(Hours newHours);
        public Task<Hours> PutAsync( int id,Hours newHours);
        public void DeleteAsync(int id);
        public List<Hours> GetHours();
        public Task<Hours> PutCostAsync( int id,Hours newHours);
    }
}
