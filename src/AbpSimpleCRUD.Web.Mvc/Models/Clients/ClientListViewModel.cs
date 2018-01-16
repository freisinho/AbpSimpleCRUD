using AbpSimpleCRUD.Clients.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpSimpleCRUD.Web.Models.Clients
{
    public class ClientListViewModel
    {
        public IReadOnlyList<GetAllClientsItem> Clients { get; set; }
    }
}
