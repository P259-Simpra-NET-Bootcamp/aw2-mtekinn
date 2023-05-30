using System;
using System.Collections.Generic;

namespace StaffManagement.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        IEnumerable<T> Where(Func<T, bool> predicate);
    }
}