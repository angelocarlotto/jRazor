using jRazor.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jRazor.Implementacao{
    public class JQuery : IJQuery
    {
        public JQuery(IJavaScript js)
        {
            this.JavaScript = js;
        }

        public IJavaScript JavaScript { get; set; }
        public IJAjax Ajax(FormMethod method)
        {
            return new JAjax(this, method);
        }

        public void Alert(string msg)
        {
            JavaScript.JavaScriptQuery.AppendLine(string.Format("alert('{0}');", msg));
        }

        public virtual void Dispose()
        {
            //TextWriter writer = JavaScript.Html.ViewContext.Writer;
            //writer.WriteLine(JavaScript.ToString());
        }

        public IJQuery Ready()
        {
            return new JqueryReady(this);
        }
        public object Val(object obj = null)
        {
            throw new NotImplementedException();
        }
    }

}