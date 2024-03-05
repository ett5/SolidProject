using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Service;


namespace Solid.Service
{
    public class HoursService:IHoursService
    {
        private readonly IHoursRepository _HoursRepository;
        public HoursService(IHoursRepository HoursRepository)
        {
            _HoursRepository = HoursRepository;
        }
        public List<Hours> GetHours()
        {
             return _HoursRepository.GetHours();
        }
       
        public async Task<Hours> PostAsync(Hours newHours)
        {
            if (newHours == null)
                return null;
          return await _HoursRepository.PostAsync(newHours);
        }

        public async Task<Hours> PutAsync(int id,Hours newHours)
        {
            if (newHours == null)
                return null;
            newHours.Id = id;
       return  await _HoursRepository.PutAsync(newHours);
         
                }
       

        public async void DeleteAsync(int id)
        {
            
            if (id == null)
                return;
            _HoursRepository.DeleteAsync(id);
        
        }

        public async Task<Hours> PutCostAsync( int id,Hours newHours)
        {
            if(newHours.Cost == null)
                return null;
            var t = _HoursRepository.GetHours().Find(x => x.EmployeeId == id);
            if (t == null)
                return null;
            t.Cost = newHours.Cost;
           t.Id = id;
          await  _HoursRepository.PutAsync(t);
            return t;
        }

       
    }
    }

