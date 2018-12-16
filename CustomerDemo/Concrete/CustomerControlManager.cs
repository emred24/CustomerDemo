using CustomerDemo.Abstract;
using CustomerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Concrete
{
    public class CustomerControlManager : ICustomerControlService
    {
        public bool IsRealPerson(Customer customer)
        {
            return true;
        }
    }
}
