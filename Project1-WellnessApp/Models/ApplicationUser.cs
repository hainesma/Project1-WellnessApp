using Microsoft.AspNetCore.Identity;
using Project1_WellnessApp.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_WellnessApp.Models
{
    public class ApplicationUser : IdentityUser
    {
       //[ForeignKey("ApplicationUserFK")]
       public ICollection<UserProfile> UserProfiles { get; set; }
        // public virtual UserProfile UserProfile { get; set; }
    }
}
