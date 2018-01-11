using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpSimpleCRUD.Clients.Dtos
{
    public class GetAllClientsItem : EntityDto<long>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
