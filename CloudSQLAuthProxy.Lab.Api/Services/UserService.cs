using AutoMapper;
using CloudSQLAuthProxy.Lab.Api.Models.ServiceModels;
using CloudSQLAuthProxy.Lab.Repository.Repositories.Carousel;

namespace CloudSQLAuthProxy.Lab.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(
            IMapper mapper,
            IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserServiceModel>> GetUsers()
        {
            return _mapper.Map<List<UserServiceModel>> (
                await _userRepository.GetAsync());
        }
    }
}
