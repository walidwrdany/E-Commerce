﻿using Microsoft.AspNetCore.Identity;

namespace eCommerce.Security.Entities
{
    public class UserLogin : IdentityUserLogin<int>
    {
        public User User { get; set; }
    }
}