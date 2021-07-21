using invoice_back.DomainObject;
using invoice_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Core
{
    public class GetAllData
    {
        private ContextInv context;
        public int Number { get; private set; }
        public List<Currency> ListOfCurrency { get; set; }
        public List<Language> ListOfLanguage { get; set; }
        public List<UOM> ListOfUOM { get; set; }
        public List<Customer> ListOfCustomer { get; set; }
        public GetAllData()
        {
            this.ListOfCurrency = new List<Currency>();
            this.ListOfLanguage = new List<Language>();
            this.ListOfUOM= new List<UOM>();
            this.ListOfCustomer = new List<Customer>();

            context = new ContextInv();
        }

        public StatusResult GetData()
        {
            StatusResult sr = new StatusResult();
            sr.SetSuccessStatus("Success");
            try
            {
                this.ListOfCurrency = context.Currency.ToList();
                this.ListOfLanguage = context.Language.ToList();
                this.ListOfCustomer = context.Customer.ToList();
                this.ListOfUOM = context.UOM.ToList();
                this.Number = context.Number.ToList().FirstOrDefault().Nomor;
            }
            catch (Exception e)
            {
                sr.SetErrorStatus(e.ToString());
            }

            return sr;
        }

    }
}
