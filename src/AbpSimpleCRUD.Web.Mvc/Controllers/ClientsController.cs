using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using AbpSimpleCRUD.Clients;
using AbpSimpleCRUD.Web.Models.Clients;
using Microsoft.AspNetCore.Mvc;

namespace AbpSimpleCRUD.Web.Mvc.Controllers
{
    public class ClientsController : AbpController
    {
        private readonly IClientAppService _clientAppService;

        public ClientsController(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        public async Task<IActionResult> Index()
        {
            var clients = await _clientAppService.GetAllClients();
            var model = new ClientListViewModel
            {
                Clients = clients.Clients
            };
            return View(model);
        }
    }
}