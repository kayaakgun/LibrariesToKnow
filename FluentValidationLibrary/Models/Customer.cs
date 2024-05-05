using System;
using System.Collections;
using System.Collections.Generic;

namespace FluentValidationLibrary.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime? Birthday { get; set; }
        //Customer.Adress[0].Id
        public IList<Address> Addresses { get; set; }

        public Gender Gender { get; set; }
    }
}
