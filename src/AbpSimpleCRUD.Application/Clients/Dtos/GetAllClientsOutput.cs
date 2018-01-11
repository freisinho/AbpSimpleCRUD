using System.Collections.Generic;

namespace AbpSimpleCRUD.Clients.Dtos
{
    public class GetAllClientsOutput
    {
        public List<GetAllClientsItem> Clients { get; set; }
    }
}
