using Entities1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1.Concrete
{
    //Çıplak class kalmasın
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
