using jRazor.Infraestrutura;
using System.Web.Mvc;

namespace jRazor.Implementacao
{
    public class JAjax : JQueryBase, IJAjax
    {
        private FormMethod method;

        public JAjax(IJQuery jq, FormMethod method)
            : base(jq)
        {
            this.Jquery = jq;
            this.method = method;

            //jq.JavaScript.JavaScriptQuery.AppendLine(string.Format("$.ajaxSettings.type='{0}'", method.ToString()));
        }

        public void Dispose()
        {
        }

        public IJRequest Load()
        {
            return new JRequest();
        }

        public void Load(string selectorTarget, string url)
        {
            Jquery.JavaScript.JavaScriptQuery.AppendLine(string.Format("$('{0}').load('{1}')", selectorTarget, url));
        }

        public void Load(string selectorTarget, string url, object param)
        {
            Jquery.JavaScript.JavaScriptQuery.AppendLine(string.Format("$('{0}').load('{1}',{2})", selectorTarget, url, param.ToString().Replace("=", ":")));
        }
    }
}