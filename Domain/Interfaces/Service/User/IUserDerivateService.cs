using Domain.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service.User
{
    public interface IUserDerivateService
    {
        Task<IEnumerable<UserSpecialtyDto>> GetAllSpecialty();
        Task<IEnumerable<UserTypeDto>> GetAllType();
    }
}
