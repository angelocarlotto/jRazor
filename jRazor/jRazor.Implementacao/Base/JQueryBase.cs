using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Jquery.NET
{
    public abstract class JQueryBase : IJqueryBase
    {
        public JQueryBase(IJQuery jquery)
        {
            this.Jquery = jquery;
        }

        public IJQuery Jquery { get; protected set; }
    }

   
}