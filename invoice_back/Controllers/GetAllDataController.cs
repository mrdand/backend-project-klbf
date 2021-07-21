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
    public class GetAllDataController : ControllerBase
    {
        private readonly ILogger<GetAllDataController> _logger;
        public GetAllDataController (ILogger<GetAllDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public GetAllDataResponse Get()
        {
            StatusResult sr = new StatusResult();
            GetAllDataResponse res = new GetAllDataResponse();
            GetAllData getData = new GetAllData();
            sr = getData.GetData();

            res.IsSuccess = sr.IsSuccess;
            res.Message = sr.Message;
            res.Number = getData.Number;
            res.ListOfCurrency = getData.ListOfCurrency;
            res.ListOfLanguage = getData.ListOfLanguage;
            res.ListOfUOM = getData.ListOfUOM;
            res.ListOfCustomer = getData.ListOfCustomer;
            return res;
        }
    }
}
