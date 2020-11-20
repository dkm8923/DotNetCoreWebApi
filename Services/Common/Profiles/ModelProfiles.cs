using AutoMapper;
using DotNetCoreWebApi.Services.Common.Dtos;
using DotNetCoreWebApi.Services.Common.Models;

namespace DotNetCoreWebApi.Services.Common.Profiles
{
    public class AddressesProfile : Profile
    {
        public AddressesProfile()
        {
            //Source -> Target
            CreateMap<Address, AddressReadDto>();
            CreateMap<AddressCreateDto, Address>();
            CreateMap<AddressUpdateDto, Address>();
            CreateMap<Address, AddressUpdateDto>();
        }
    }

    public class UsaStatesProfile : Profile
    {
        public UsaStatesProfile()
        {
            //Source -> Target
            CreateMap<UsaState, UsaStateReadDto>();
            CreateMap<UsaStateCreateDto, UsaState>();
            CreateMap<UsaStateUpdateDto, UsaState>();
            CreateMap<UsaState, UsaStateUpdateDto>();
        }
    }
}