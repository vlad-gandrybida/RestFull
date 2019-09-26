using System;
using Microsoft.AspNetCore.Identity;

namespace RestFull.Data.Entities.User
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string PhotoUrl { get; set; }

        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }
    }
}
