using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Models
{
    public class SaveRequestInv
    {
        public string InvNo { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string FromAddress { get; set; }
        public string ToName { get; set; }
        public string ToAddress { get; set; }
        public string DueDate { get; set; }
        public string InvDue { get; set; }
        public string PurchaseNo { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public List<Detail> Detail { get; set; }

    }

    public class Detail
    {
        public string OrderName { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
