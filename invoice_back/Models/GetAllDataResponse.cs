using invoice_back.DomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Models
{
    public class GetAllDataResponse
    {
        public List<Currency> ListOfCurrency { get; set; }
        public List<Language> ListOfLanguage { get; set; }
        public List<UOM> ListOfUOM { get; set; }
        public List<Customer> ListOfCustomer { get; set; }
        public int Number { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
