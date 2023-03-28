using Entities1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }

        public string CompanyName { get; set; }

        public string City { get; set; }

    }
}
