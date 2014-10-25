using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Jquery.NET
{
    public class JavaScript : IJavaScript
    {
        public JavaScript(HtmlHelper html)
        {
            this.Html = html;
            JavaScriptQuery = new StringBuilder();
            JavaScriptQuery.AppendLine("<script type='text/javascript'>");
        }

        public HtmlHelper Html
        {
            get;
            set;
        }

        public StringBuilder JavaScriptQuery { get; set; }
        public void Alert(string msg)
        {
            JavaScriptQuery.AppendLine(string.Format("alert('{0}');", msg));
        }

        public void Dispose()
        {
            TextWriter writer = Html.ViewContext.Writer;
            JavaScriptQuery.AppendLine("</script>");
            writer.WriteLine(JavaScriptQuery.ToString());
        }

        public IJQuery Jquery()
        {
            return new JQuery(this);
        }

        public void AddFunction(string funcName, Expression<Func<int, int>> fn)
        {
            var visitor = new JsExpressionVisitor();
            visitor.Visit(fn);
            JavaScriptQuery.AppendLine(string.Format("var {0}={1};", funcName, visitor.JavaScriptCode));
        }

        public override string ToString()
        {
            return JavaScriptQuery.ToString();
        }
    }

}