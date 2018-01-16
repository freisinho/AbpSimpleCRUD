using AbpSimpleCRUD.Clients.Dtos;
using System.Collections.Generic;


namespace AbpSimpleCRUD.Web.Models.Clients
{
    public class ClientListViewModel
    {
        public IReadOnlyList<GetAllClientsItem> Clients { get; set; }
    }
}
