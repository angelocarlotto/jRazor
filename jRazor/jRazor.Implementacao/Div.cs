using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Jquery.NET
{
    public class Div : HtmlComponentBase, IDisposable
    {
        public Div(HtmlHelper html)
            : this(html, Guid.NewGuid().ToString())
        {
        }

        public Div(HtmlHelper html, string id)
            : base(html, id)
        {
            HtmlQuery.AppendLine(string.Format("<div id='{0}' name='{0}'>", ID));
        }

        public void Dispose()
        {
            TextWriter writer = Html.ViewContext.Writer;
            HtmlQuery.AppendLine("</div>");
            writer.WriteLine(HtmlQuery.ToString());
        }
    }

}