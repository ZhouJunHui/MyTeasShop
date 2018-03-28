using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Orders
    {
        public int OrId { get; set; }
        public int Uid { get; set; }
        public string Ordernumber { get; set; }
        public DateTime Ordertime { get; set; }
        public decimal Total { get; set; }
        public int RecId { get; set; }
        public string Rname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
