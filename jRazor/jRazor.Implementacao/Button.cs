using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Jquery.NET
{
    public class Button : HtmlComponentBase, IDisposable
    {
        public Button(HtmlHelper html)
            : this(html, Guid.NewGuid().ToString())
        {
        }

        public Button(HtmlHelper html, string id)
            : base(html, id)
        {
            HtmlQuery.AppendLine(string.Format("<input type='button' id='{0}'", ID));
        }

        public object value { get; set; }

        public Button Click(string jsOnclick)
        {
            HtmlQuery.Append(string.Format(" onclick='javascript:{0}' ", jsOnclick));
            return this;
        }

        public void Dispose()
        {
            HtmlQuery.AppendLine(string.Format(" value='{0}'", value.ToString()));
            TextWriter writer = Html.ViewContext.Writer;
            HtmlQuery.AppendLine(" ></input>");
            writer.WriteLine(HtmlQuery.ToString());
        }

        public Button Value(object value = null)
        {
            //if (value != null)
            //{
            //    HtmlQuery.AppendLine(string.Format(" value='{0}'", value.ToString()));
            //}
            this.value = value;
            return this;
        }
    }

}