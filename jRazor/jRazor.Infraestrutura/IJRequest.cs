using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jRazor.Infraestrutura
{
    public interface IJRequest : IDisposable
    {
        IJRequest CallBack(string callback);

        IJRequest FormMethod(FormMethod method);

        IJRequest Params(object param);

        IJRequest URL(string url);
    }
}