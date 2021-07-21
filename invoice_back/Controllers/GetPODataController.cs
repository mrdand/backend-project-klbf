using invoice_back.Core;
using invoice_back.DomainObject;
using invoice_back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPODataController : ControllerBase
    {
        private readonly ILogger<GetAllDataController> _logger;
        public GetPODataController(ILogger<GetAllDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Purchase> Get()
        {
            StatusResult sr = new StatusResult();
            List<Purchase> listPurchase = new List<Purchase>();
            GetPODataResponse response = new GetPODataResponse();
            GetPO getData = new GetPO();
            sr = getData.GetData();

            if (sr.IsSuccess)
            {
                listPurchase = getData.ListOfPurchase;
            }
            return listPurchase;
        }
    }
}
