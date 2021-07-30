using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_WellnessApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public System.DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
    }
}
