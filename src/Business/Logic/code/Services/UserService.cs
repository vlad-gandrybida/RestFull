using RestFull.Business.Interfaces.Services;
using RestFull.Data.SQL.Repository;

namespace RestFull.Business.Logic.Services
{
    public class UserService : IUserService
    {
        private UserRepository UserRepository { get; }

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }
    }
}
