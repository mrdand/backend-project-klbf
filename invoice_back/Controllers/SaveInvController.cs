using invoice_back.Core;
using invoice_back.DomainObject;
using invoice_back.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class SaveInvController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public SaveResponseInv Post(SaveRequestInv request)
        {
            StatusResult sr = new StatusResult();
            SaveResponseInv res = new SaveResponseInv();
            SaveInv saveinv = new SaveInv(request.InvNo, request.Language, request.Currency, request.FromAddress, request.ToName, request.ToAddress, request.DueDate, request.InvDue, request.PurchaseNo, request.SubTotal, request.Discount, request.GrandTotal, request.Detail);
            sr = saveinv.Save();
            res.isSuccess = sr.IsSuccess;
            res.Message = sr.Message;
            res.Nomor = saveinv.Nomor;
            return res;
        }
    }
}
