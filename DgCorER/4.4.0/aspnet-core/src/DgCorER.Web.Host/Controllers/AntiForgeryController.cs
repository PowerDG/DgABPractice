using Microsoft.AspNetCore.Antiforgery;
using DgCorER.Controllers;

namespace DgCorER.Web.Host.Controllers
{
    public class AntiForgeryController : DgCorERControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
