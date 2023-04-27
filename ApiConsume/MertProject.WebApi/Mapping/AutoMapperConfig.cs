using AutoMapper;
using MertProject.DtoLayer.Dtos.RoomDto;
using MertProject.EntityLayer.Concrate;

namespace MertProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto,Room>().ReverseMap();
            CreateMap<UpdateRoomDto,Room>().ReverseMap();   
        }
    }
}
