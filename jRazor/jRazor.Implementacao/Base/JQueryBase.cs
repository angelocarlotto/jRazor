using jRazor.Infraestrutura;

namespace jRazor.Implementacao
{
    public abstract class JQueryBase : IJqueryBase
    {
        public JQueryBase(IJQuery jquery)
        {
            this.Jquery = jquery;
        }

        public IJQuery Jquery { get; protected set; }
    }
}