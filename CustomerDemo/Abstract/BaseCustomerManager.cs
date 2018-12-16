using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CustomerDemo.Entities;

namespace CustomerDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get()
        {
            throw new NotImplementedException();
        }

        public List<Customer> Get(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Customer entity)
        {
            Console.WriteLine($"{entity.Name} saved to Db.");
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }

    }
}
