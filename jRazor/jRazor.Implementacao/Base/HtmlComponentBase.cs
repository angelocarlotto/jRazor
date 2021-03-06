﻿using System.Text;
using System.Web.Mvc;

namespace jRazor.Implementacao
{
    public abstract class HtmlComponentBase
    {
        public HtmlComponentBase(HtmlHelper html, string id)
        {
            this.Html = html;
            HtmlQuery = new StringBuilder();
            ID = id;
        }

        public HtmlHelper Html
        {
            get;
            set;
        }

        public StringBuilder HtmlQuery { get; set; }

        public string ID { get; protected set; }

        public string IDSelector { get { return string.Format("#{0}", ID); } }

        public string NameSelector { get { return string.Format("[name={0}]", ID); } }

        public object Val()
        {
            return string.Format("$(\"{0}\").val()", IDSelector);
        }
    }
}