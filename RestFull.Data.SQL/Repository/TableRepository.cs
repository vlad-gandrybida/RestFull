using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IEnumerable<Table> GetAll()
        {
            return Database.Tables.AsEnumerable();
        }

        public Table GetById(int id)
        {
            return Database.Tables.FirstOrDefault(t => t.ID == id);
        }

        public Table Add(Table item)
        {
            throw new NotImplementedException();
        }

        public Table Update(Table item)
        {
            throw new NotImplementedException();
        }

        public Table Delete(Table item)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }
    }
}
