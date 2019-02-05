using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        int AddItem(T item);
        int DeleteItem(T item);
        int UpdateItem(T item);
        T GetItem(Expression<Func<T, bool>> lambda = null);
        ICollection<T> GetAllItem(Expression<Func<T, bool>> lambda = null);
    }
}