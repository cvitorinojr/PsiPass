using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile:Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, User>()
                .ReverseMap();

            CreateMap<UserDtoResult, User>()
                .ReverseMap();

            CreateMap<UserTypeDto, UserType>()
                .ReverseMap();

            CreateMap<UserSpecialtyDto, UserSpecialty>()
                .ReverseMap();

        }
    }
}
