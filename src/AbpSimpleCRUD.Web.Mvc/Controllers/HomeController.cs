using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpSimpleCRUD.Controllers;

namespace AbpSimpleCRUD.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpSimpleCRUDControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
