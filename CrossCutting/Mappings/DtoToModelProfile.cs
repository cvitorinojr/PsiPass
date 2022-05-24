using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities.User;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile:Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();

            CreateMap<UserTypeModel, UserTypeDto>()
                .ReverseMap();
            
            CreateMap<UserSpecialtyModel, UserSpecialtyDto>()
                .ReverseMap();
        }
    }
}
