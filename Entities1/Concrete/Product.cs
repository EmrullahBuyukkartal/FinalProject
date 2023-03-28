using Entities1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
