using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestFull.Data.Interfaces.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<T> Delete(T item);
        Task<int> Commit();
    }
}
