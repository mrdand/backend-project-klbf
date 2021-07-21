using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.DomainObject
{
    public class InvDetail
    {
        public int ID { get; set; }
        public int InvHeaderID { get; set; }
        public string OrderName { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
