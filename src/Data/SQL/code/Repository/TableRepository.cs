using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestFull.Data.Entities.Restaurant;
using RestFull.Data.Interfaces.Repository;

namespace RestFull.Data.SQL.Repository
{
    public class TableRepository : ITableRepository
    {
        private RestFullDbContext Database { get; }

        public TableRepository(RestFullDbContext database)
        {
            Database = database;
        }

        public async Task<IEnumerable<Table>> GetAll()
        {
            return Database.Tables.AsEnumerable();
        }

        public async Task<Table> GetById(string id)
        {
            return await Database.Tables.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Table> Add(Table item)
        {
            throw new NotImplementedException();
        }

        public async Task<Table> Update(Table item)
        {
            throw new NotImplementedException();
        }

        public async Task<Table> Delete(Table item)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
