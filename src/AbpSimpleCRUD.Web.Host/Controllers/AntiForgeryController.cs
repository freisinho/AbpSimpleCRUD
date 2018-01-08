using Microsoft.AspNetCore.Antiforgery;
using AbpSimpleCRUD.Controllers;

namespace AbpSimpleCRUD.Web.Host.Controllers
{
    public class AntiForgeryController : AbpSimpleCRUDControllerBase
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
