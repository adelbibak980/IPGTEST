using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPGTEST.DTO
{
    public class Response : object
    {
        public Response() : base()
        {

        }

        public string Status { get; set; }

        public string ReturnId { get; set; }

        public string Message { get; set; }

    }
}