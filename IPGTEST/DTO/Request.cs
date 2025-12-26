using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPGTEST.DTO
{
    public class Request : object
    {
        public Request() : base()
        {

        }

        public long Tid { get; set; }

        public string digitalreceipt { get; set; }


    }
}