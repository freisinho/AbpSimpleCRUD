using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace AbpSimpleCRUD.Web.Models.Clients
{
    public class ClientViewModel : EntityDto<long>
    {
        private const int MaxNameSize = 32;

        [Required]
        [MaxLength(MaxNameSize)]
        public string FirstName { get; set; }

        [MaxLength(MaxNameSize)]
        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
