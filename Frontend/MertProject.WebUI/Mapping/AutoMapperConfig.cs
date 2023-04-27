using AutoMapper;
using MertProject.EntityLayer.Concrate;
using MertProject.WebUI.Dtos.ServiceDto;

namespace MertProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
        }
    }
}
