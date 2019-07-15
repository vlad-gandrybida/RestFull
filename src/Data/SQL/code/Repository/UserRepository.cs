using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestFull.Data.Entities.User;
using RestFull.Data.Interfaces.Repository;

namespace RestFull.Data.SQL.Repository
{
    public class UserRepository : IUserRepository
    {
        private RestFullDbContext Database { get; }

        public UserRepository(RestFullDbContext database)
        {
            Database = database;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return Database.Users.AsEnumerable();
        }

        public async Task<User> GetById(int id)
        {
            return await Database.Users.FirstOrDefaultAsync(u => u.Id == id);
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
