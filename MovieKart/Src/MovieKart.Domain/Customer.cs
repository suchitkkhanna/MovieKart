﻿
using System;
namespace MovieKart.Domain
{
    public class Customer : EntityBase
    {
        public Guid UniqueKey { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string IdentityCard { get; set; }

        public string Mobile { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime RegistrationDate { get; set; }

    }
}
