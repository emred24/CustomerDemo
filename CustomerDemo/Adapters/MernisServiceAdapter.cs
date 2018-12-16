using CustomerDemo.Abstract;
using CustomerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerControlService
    {
        public bool IsRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient soapClient = new MernisServiceReference.KPSPublicSoapClient();
            return soapClient.TCKimlikNoDogrula( Convert.ToInt64(customer.IdentificationId),
                                                 customer.Name.ToUpper(),
                                                 customer.Surname.ToUpper(),
                                                 customer.Birthday.Year);
        }
    }
}
