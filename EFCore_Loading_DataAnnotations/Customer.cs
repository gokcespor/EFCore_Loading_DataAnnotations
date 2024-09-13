using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Loading_DataAnnotations
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
