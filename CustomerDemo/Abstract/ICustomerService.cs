using CustomerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
    }
}
