using CustomerDemo.Abstract;
using CustomerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Concrete
{
    public class EnterpriseCustomerManager : BaseCustomerManager
    {
        private ICustomerControlService _customerControlService;

        public EnterpriseCustomerManager(ICustomerControlService persolControlService)
        {
            _customerControlService = persolControlService;
        }

        public override void Save(Customer entity)
        {
            if (_customerControlService.IsRealPerson(entity))
            {
                base.Save(entity);
            }
            else
            {
                throw new Exception("Exception : asdfghjl.");
            }
        }
    }
}
