using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jRazor.Infraestrutura
{

    public interface IJQuery : IDisposable
    {
        IJavaScript JavaScript { get; set; }

        IJAjax Ajax(FormMethod method);

        void Alert(string msg);

        IJQuery Ready();

        object Val(object obj = null);
    }

}