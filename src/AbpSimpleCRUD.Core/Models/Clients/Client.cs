using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbpSimpleCRUD.Models.Clients
{
    [Table("Clients")]
    public class Client : FullAuditedEntity<long>
    {
        private const int MaxNameSize = 32;

        [Required]
        [MaxLength(MaxNameSize)]
        public string FirstName { get; set; }

        [MaxLength(MaxNameSize)]
        public string LastName { get; set; }

        public int Age { get; private set;}


        public Client() => CreationTime = DateTime.Now;


        public void AddAge(int age)
        {
            if(age < 0)
                throw new ArgumentOutOfRangeException();

            Age = age;
        } 

    }
}
