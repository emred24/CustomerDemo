using CustomerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Entities
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = "undefined";
        public string Surname { get; set; } = "undefined";
        public DateTime Birthday { get; set; }
        public string IdentificationId { get; set; } = "undefined";
    }
}
