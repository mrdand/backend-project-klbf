using invoice_back.DomainObject;
using invoice_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Core
{
    public class GetPO
    {
        private ContextInv context;
        public List<Purchase> ListOfPurchase { get; set; }
        public GetPO()
        {
            this.ListOfPurchase = new List<Purchase>();
            context = new ContextInv();
        }
        public StatusResult GetData()
        {
            StatusResult sr = new StatusResult();
            sr.SetSuccessStatus("Success");
            try
            {
                this.ListOfPurchase = context.Purchase.ToList();
            }
            catch (Exception ex)
            {
                sr.SetErrorStatus(ex.ToString());
            }

            return sr;
        }
    }
}
