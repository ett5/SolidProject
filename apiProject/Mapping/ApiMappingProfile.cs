
using AutoMapper;
using Solid.api.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;

namespace Web.Net.API.Mapping
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {

            CreateMap<HoursPostModel, Hours>().ReverseMap();
            CreateMap<TasksPostModel, Tasks>().ReverseMap();
            CreateMap<EmployeePostModel, Employee >().ReverseMap();
        }
    }
}
