using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace jRazor.Infraestrutura
{
    public interface IJAjax : IDisposable, IJqueryBase
    {
        void Load(string selectorTarget, string url);

        void Load(string selectorTarget, string url, object param);
    }

}