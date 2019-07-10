using System;
using System.Collections.Generic;
using System.Text;

namespace RestFull.Data.Interfaces.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T item);
        T Update(T item);
        T Delete(T item);
        int Commit();
    }
}
