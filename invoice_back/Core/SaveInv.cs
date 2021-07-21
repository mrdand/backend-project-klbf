using invoice_back.DomainObject;
using invoice_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Core
{
    public class SaveInv
    {
        private ContextInv context;
        public int Nomor { get; set; }
        private InvHeader Header { get; set; }
        private List<InvDetail> ListOfDetail { get; set; }
        public SaveInv(string invno, string language, string currency, string from,
            string nameto, string addressto, string duedate, string invdue, 
            string prchno, decimal subtotal, decimal disc, decimal grandtotal, 
            List<Detail> detail)
        {
            Header = new InvHeader();
            Header.InvNo = invno;
            Header.Language = language;
            Header.Currency = currency;
            Header.FromAddress = from;
            Header.ToName = nameto;
            Header.ToAddress = addressto;
            Header.DueDate = !string.IsNullOrEmpty(duedate) ? Convert.ToDateTime(duedate).Date : DateTime.Now.Date;
            Header.InvDue = invdue;
            Header.PurchaseNo = prchno;
            Header.SubTotal = subtotal;
            Header.Discount = disc;
            Header.GrandTotal = grandtotal;
            ListOfDetail = new List<InvDetail>();
            foreach(var data in detail)
            {
                InvDetail invdetail = new InvDetail();
                invdetail.OrderName = data.OrderName;
                invdetail.Qty = data.Qty;
                invdetail.Rate = data.Rate;
                invdetail.Amount = data.Amount;
                ListOfDetail.Add(invdetail);
            }
            context = new ContextInv();
        }

        public StatusResult Save()
        {
            StatusResult sr = new StatusResult();
            sr.SetSuccessStatus("Invoice No " + Header.InvNo + " has been saved");
            try
            {
                Number num = context.Number.ToList().FirstOrDefault();
                if (num != null && num.ID > 0)
                {
                    num.Nomor++;
                    Nomor = num.Nomor;
                    context.Entry(num).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    var datas = context.SaveChangesAsync().Result;
                }

                context = new ContextInv();
                context.InvHeader.Add(Header);
                context.SaveChanges();

                if (Header.ID > 0)
                {
                    foreach (var data in ListOfDetail)
                    {
                        context = new ContextInv();
                        data.InvHeaderID = Header.ID;
                        context.InvDetail.Add(data);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                sr.SetErrorStatus(e.ToString());
            }
            return sr;
        }
    }
}
