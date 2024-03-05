using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Solid.Data
{
    public class HoursRepository : IHoursRepository
    {private readonly DataContext _DataContext;
        public HoursRepository(DataContext dataContext)
        {
            _DataContext = dataContext;
        }
        public Hours GetById(int id)
        {
            return _DataContext.HoursList.Include(u=>u.Employee).Include(u=>u.Tasks).First(u=>u.Id==id);
        }

        public List<Hours> GetHours()
        {
           return  _DataContext.HoursList.Include(u=>u.Tasks).Include(u=>u.Employee).ToList();

        }
        public async Task<Hours> PostAsync(Hours newHours)
        {
            _DataContext.HoursList.Add(newHours);
            await _DataContext.SaveChangesAsync();
            return newHours;
        }
        public async void DeleteAsync(int id)

        {
        var t=   GetById(id);
            if (t != null) {
                _DataContext.HoursList.Remove(t);
               await _DataContext.SaveChangesAsync();
            };
            

        }
        public async Task<Hours> PutAsync(Hours newHours)

        {
            var f = GetById(newHours.Id);
            if (f ==null)
                return null;
            f.Cost = newHours.Cost;
            f.End = newHours.End;
            f.Start = newHours.Start;
           await _DataContext.SaveChangesAsync();
            return f;
        }
       
    }
}
