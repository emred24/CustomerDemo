using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Abstract
{
    public interface IGenericService<T>
    {
        T Get();

        List<T> Get(Expression<Func<T, bool>> expression);

        bool Update(T entity);

        bool Delete(int id);

        bool Delete(T entity);
    }
}
