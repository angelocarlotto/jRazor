using jRazor.Infraestrutura;
using System.Web.Mvc;

namespace jRazor.Implementacao
{
    public static class ExtesionHTML
    {
        public static Button Button(this HtmlHelper html)
        {
            return new Button(html);
        }

        public static Button Button(this HtmlHelper html, string id)
        {
            return new Button(html, id);
        }

        public static Div Div(this HtmlHelper html, string id)
        {
            return new Div(html, id);
        }

        public static Div Div(this HtmlHelper html)
        {
            return new Div(html);
        }

        public static InputText InputText(this HtmlHelper html, string id)
        {
            return new InputText(html, id);
        }

        public static InputText InputText(this HtmlHelper html)
        {
            return new InputText(html);
        }

        public static InputText InputText(this HtmlHelper html, object value)
        {
            return new InputText(html);
        }

        public static IJavaScript JavaScript(this HtmlHelper html)
        {
            return new JavaScript(html);
        }

        public static IJQuery Jquery(this IJavaScript jq)
        {
            return (IJQuery)new JQuery(jq);
        }

        public static object Val(this IJQuery html, object val = null)
        {
            return html.Val(val);
        }

        public static object Val(this HtmlComponentBase html)
        {
            return html;
        }
    }
}