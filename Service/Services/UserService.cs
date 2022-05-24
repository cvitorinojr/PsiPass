using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities.User;
using Domain.Interfaces.Service.User;
using AutoMapper;
using Domain.Dtos.User;
using Domain.Models;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UserDto>(entity);
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var entities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

        public async Task<UserDtoResult> Post(UserDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<User>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserDtoResult>(result);
        }

        public async Task<UserDtoResult> Put(UserDto user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<User>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserDtoResult>(result);
        }
        
        public async Task<IEnumerable<UserDto>> GetByCRP(string crp)
        {
            var entities = await _repository.FindBy(x => x.CRP.Equals(crp));
            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

    }
}
