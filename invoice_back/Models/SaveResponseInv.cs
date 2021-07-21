using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Models
{
    public class SaveResponseInv
    {
        public bool isSuccess { get; set; }
        public string Message { get; set; }
        public int Nomor { get; set; }
    }
}
