using Abp.Application.Services.Dto;

namespace AbpSimpleCRUD.Clients.Dtos
{
    public class GetClientByIdOutput : EntityDto<long>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
