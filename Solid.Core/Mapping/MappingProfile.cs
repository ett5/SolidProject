using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hours, HoursDTO>().ReverseMap();
            CreateMap<Tasks, TasksDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
