using E_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace E_Ticaret.WebUI.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

