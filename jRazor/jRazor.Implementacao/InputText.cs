using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Jquery.NET
{
    
    public class InputText : HtmlComponentBase, IDisposable
    {
        public InputText(HtmlHelper html)
            : this(html, Guid.NewGuid().ToString())
        {
        }

        public InputText(HtmlHelper html, string id)
            : base(html, id)
        {
            HtmlQuery.AppendLine(string.Format("<input type='text' id='{0}'", ID));
        }

        public InputText(HtmlHelper html, object value)
            : this(html)
        {
            HtmlQuery.AppendLine(string.Format("<input type='text' id='{0}'", ID));
            HtmlQuery.AppendLine(string.Format(" value='{0}'", value.ToString()));
        }

        public InputText Change(string jsOnclick)
        {
            HtmlQuery.Append(string.Format(" onchange='javascript:{0}' ", jsOnclick));
            return this;
        }

        public void Dispose()
        {
            TextWriter writer = Html.ViewContext.Writer;
            HtmlQuery.AppendLine(" ></input>");
            writer.WriteLine(HtmlQuery.ToString());
        }

        public void OnChange<T>(Expression<Action<T>> delegatew)
        {
        }
        public InputText Value(object value = null)
        {
            if (value != null)
            {
                HtmlQuery.AppendLine(string.Format(" value='{0}'", value.ToString()));
            }
            return this;
        }
    }

}