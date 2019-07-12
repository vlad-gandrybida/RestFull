using System;
using System.Collections.Generic;
using System.Text;

namespace RestFull.Data.Entities.User
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
