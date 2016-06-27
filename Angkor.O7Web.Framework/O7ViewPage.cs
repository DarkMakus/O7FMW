using System.Web.Mvc;

namespace Angkor.O7Framework.Web
{
    public abstract class O7ViewPage : WebViewPage
    {
        public virtual new O7User User => base.User as O7User;
    }

    public abstract class O7ViewPage<TModel> : WebViewPage<TModel>
    {
        public virtual new O7User User => base.User as O7User;
    }
}