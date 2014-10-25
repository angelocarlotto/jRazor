using jRazor.Infraestrutura;
using System;
using System.Web.Mvc;

namespace jRazor.Implementacao
{
    public class JRequest : IJRequest
    {
        public IJRequest CallBack(string callback)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public JQuery End()
        {
            throw new System.NotImplementedException();
        }

        public IJRequest FormMethod(FormMethod method)
        {
            throw new System.NotImplementedException();
        }

        public IJRequest Params(object param)
        {
            throw new System.NotImplementedException();
        }

        public IJRequest URL(string url)
        {
            throw new System.NotImplementedException();
        }
    }
}