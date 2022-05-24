using AutoMapper;
using Domain.Entities.User;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile:Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<User, UserModel>()
                .ReverseMap();

            CreateMap<UserType, UserTypeModel>()
                .ReverseMap();

            CreateMap<UserSpecialty, UserSpecialtyModel>()
                .ReverseMap();
        }
    }
}
