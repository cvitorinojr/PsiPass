using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities.User;
using Domain.Interfaces.Service.User;
using AutoMapper;
using Domain.Dtos.User;
using Domain.Models;
using Data.Context;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository;
        private IRepository<UserType> _typeRepository;
        private IRepository<UserSpecialty> _specialtyRespository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> Repository, IRepository<UserType> TypeRepository, IRepository<UserSpecialty> SpecialtyRespository, IMapper mapper)
        {
            _repository = Repository;
            _typeRepository = TypeRepository;
            _specialtyRespository = SpecialtyRespository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDtoResult> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);

            if (entity == null)
                throw new ArgumentException("Usuario não encontrado");

            return _mapper.Map<UserDtoResult>(entity);
        }

        public async Task<IEnumerable<UserDtoResult>> GetAll()
        {
            var entities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDtoResult>>(entities);
        }

        public async Task<UserDtoResult> Post(UserDto user)
        {
            if (!(await _typeRepository.ExistAsync(user.UserTypeId)))
                throw new ArgumentException("Tipo de usuario não existe");

            if (!(await _specialtyRespository.ExistAsync(user.UserSpecialtyId)))
                throw new ArgumentException("Especialidade não existe");
            
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<User>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserDtoResult>(result);
        }

        public async Task<UserDtoResult> Put(UserDto user, int id)
        {

            var model = _mapper.Map<UserModel>(user);

            if (model.UserTypeId != 0 && !(await _typeRepository.ExistAsync(model.UserTypeId)))
                throw new ArgumentException("Tipo de usuario não existe");

            if (model.UserSpecialtyId != 0 && !(await _specialtyRespository.ExistAsync(model.UserSpecialtyId)))
                throw new ArgumentException("Especialidade não existe");

            var entity = _mapper.Map<User>(model);
            var temp = _repository.SelectAsync(id);

            entity.UserTypeId = (entity.UserTypeId == 0 ? temp.Result.UserTypeId : entity.UserTypeId);
            entity.UserSpecialtyId = (entity.UserSpecialtyId == 0 ? temp.Result.UserSpecialtyId : entity.UserSpecialtyId);
            entity.CRP = (string.IsNullOrEmpty(entity.CRP) ? temp.Result.CRP : entity.CRP);

            entity.Id = id;
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<UserDtoResult>(result);
        }
        
        public async Task<IEnumerable<UserDtoResult>> GetByCRP(string crp)
        {
            var entities = await _repository.FindBy(x => x.CRP.Equals(crp));

            if (entities == null)
                throw new ArgumentException("Usuario não encontrado");

            return _mapper.Map<IEnumerable<UserDtoResult>>(entities);
        }

    }
}
