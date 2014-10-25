using jRazor.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jRazor.Implementacao
{
    public class JqueryReady : JQuery, IJqueryReady
    {
        public JqueryReady(IJQuery jq)
            : base(jq.JavaScript)
        {
            JavaScript.JavaScriptQuery.AppendLine("$(document).ready(function(){");
        }

        public override void Dispose()
        {
            JavaScript.JavaScriptQuery.AppendLine("});");
        }
    }

}