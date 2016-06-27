using System.Web.Mvc;

namespace Angkor.O7Framework.Web
{
    public class O7Controller : Controller
    {
        protected new O7User User => HttpContext.User as O7User;
    }
}