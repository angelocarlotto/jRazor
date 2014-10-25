using jRazor.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jRazor.Implementacao
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