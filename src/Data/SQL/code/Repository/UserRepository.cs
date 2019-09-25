using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestFull.Data.Entities.User;
using RestFull.Data.Interfaces.Repository;

namespace RestFull.Data.SQL.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Add(User item)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Update(User item)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Delete(User item)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
