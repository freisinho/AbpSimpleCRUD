﻿using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbpSimpleCRUD.Domain.Clients
{
    [Table("Clients")]
    public class Client : FullAuditedEntity<long>
    {
        private const int MaxNameSize = 32;

        [Required]
        [MaxLength(MaxNameSize)]
        public string FirstName { get; private set; }

        [MaxLength(MaxNameSize)]
        public string LastName { get; private set; }

        public int Age { get; private set;}

        private Client()
        {
            CreationTime = DateTime.Now;
        }

        public Client(string firstName, string lastName)
        {
            CreationTime = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
        }


        public void AddAge(int age)
        {
            if(age < 0)
                throw new ArgumentOutOfRangeException("Age", "Age can't be a negative number");

            Age = age;
        } 

    }
}
