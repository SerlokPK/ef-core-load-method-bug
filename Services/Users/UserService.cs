using AutoMapper;
using Common;
using Common.Helpers;
using DomainModels;
using Interfaces.Repositories;
using Interfaces.Services;
using Microsoft.Extensions.Options;

namespace Services.UserSer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UserService(IUserRepository userRepository, IMapper mapper,
                            IOptions<AppSettings> options)
        {
            DependencyHelper.ThrowIfNull(userRepository, mapper, options);

            _userRepository = userRepository;
            _mapper = mapper;
            _appSettings = options.Value;
        }

        public Cycle GetWithInclude()
        {
            return _userRepository.GetWithInclude();
        }

        public Cycle GetWithLoad()
        {
            return _userRepository.GetWithLoad();
        }
    }
}
