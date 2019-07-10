using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IEnumerable<User> GetAll()
        {
            return Database.Users.AsEnumerable();
        }

        public User GetById(int id)
        {
            return Database.Users.FirstOrDefault(u => u.ID == id);
        }

        public User Add(User item)
        {
            throw new NotImplementedException();
        }

        public User Update(User item)
        {
            throw new NotImplementedException();
        }

        public User Delete(User item)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }
    }
}
