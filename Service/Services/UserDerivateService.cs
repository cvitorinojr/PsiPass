using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Interfaces.Service.User;


namespace Service.Services
{
    public class UserDerivateService : IUserDerivateService
    {
        private IRepository<UserSpecialty> _specialtyRepository;
        private IRepository<UserType> _typeRepository;
        private readonly IMapper _mapper;

        public UserDerivateService(IRepository<UserSpecialty> SpecialtyRepository, IRepository<UserType> TypeRepository, IMapper mapper)
        {
            _specialtyRepository = SpecialtyRepository;
            _typeRepository = TypeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserSpecialtyDto>> GetAllSpecialty()
        {
            var entities = await _specialtyRepository.SelectAsync();
            return _mapper.Map<IEnumerable<UserSpecialtyDto>>(entities);
        }

        public async Task<IEnumerable<UserTypeDto>> GetAllType()
        {
            var entities = await _typeRepository.SelectAsync();
            return _mapper.Map<IEnumerable<UserTypeDto>>(entities);
        }
    }
}
