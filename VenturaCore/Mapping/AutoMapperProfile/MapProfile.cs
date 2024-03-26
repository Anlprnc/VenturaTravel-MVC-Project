using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace VenturaCore.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDtos, Announcement>();
            CreateMap<Announcement, AnnouncementAddDtos>();

            CreateMap<AppUserRegisterDtos, AppUser>();
            CreateMap<AppUser, AppUserRegisterDtos>();

            CreateMap<AppUserLoginDtos, AppUser>();
            CreateMap<AppUser, AppUserLoginDtos>();
        }
    }
}