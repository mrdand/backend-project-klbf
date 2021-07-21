﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.DomainObject
{
    public class StatusResult
    {
        public bool IsSuccess { get; private set; }
        public string Message { get; set; }
        public void SetSuccessStatus(string message)
        {
            this.IsSuccess = true;
            this.Message = message;
        }
        public void SetErrorStatus(string message)
        {
            this.IsSuccess = false;
            this.Message = message;
        }

    }
}
