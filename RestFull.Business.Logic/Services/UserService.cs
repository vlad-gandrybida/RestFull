using System;
using System.Collections.Generic;
using System.Text;
using RestFull.Business.Interfaces.Services;
using RestFull.Data.Interfaces.Repository;

namespace RestFull.Business.Logic.Services
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get; }

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
    }
}
