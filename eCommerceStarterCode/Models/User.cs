﻿using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set;
        }
        public string LastName { get; set; }
        public string RegistrationDate { get; set; }

        public string Password { get; set; }
    }
}
