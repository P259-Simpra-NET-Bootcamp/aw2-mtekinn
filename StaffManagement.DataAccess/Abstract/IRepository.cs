using System.Linq.Expressions;

namespace StaffManagement.DataAccess.Abstract;

public interface IRepository<T>
{
    public interface IIRepository<T>
    {
        List <T> List();
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> List(Expression<Func<T, bool>> filter);
        T Find(Expression<Func<T, bool>> where);
    }
}