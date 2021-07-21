using invoice_back.DomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Models
{
    public class GetPODataResponse
    {
        public List<Purchase> ListOfPurchase { get; set; }
        public bool isSuccess { get; set; }
        public string Message { get; set; }
    }
}
