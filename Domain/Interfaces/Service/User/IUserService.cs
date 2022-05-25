using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dtos.User;
using Domain.Entities.User;

namespace Domain.Interfaces.Service.User
{
    public interface IUserService
    {
        Task<UserDtoResult> Get(int id);
        Task<IEnumerable<UserDtoResult>> GetAll();
        Task<IEnumerable<UserDtoResult>> GetByCRP(string crp);
        Task<UserDtoResult> Post(UserDto user);
        Task<UserDtoResult> Put(UserDto user, int id);
        Task<bool> Delete(int id);
    }
}
