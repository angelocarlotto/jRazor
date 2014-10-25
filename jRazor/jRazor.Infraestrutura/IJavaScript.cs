using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;

namespace jRazor.Infraestrutura
{
    public interface IJavaScript : IDisposable
    {
        void AddFunction(string funcName, Expression<Func<int, int>> fn);
        HtmlHelper Html { get; set; }

        StringBuilder JavaScriptQuery { get; set; }
        void Alert(string msg);

        IJQuery Jquery();
    }
}