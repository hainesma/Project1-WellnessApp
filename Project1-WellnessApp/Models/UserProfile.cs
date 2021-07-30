using Project1_WellnessApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_WellnessApp.Context
{
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<FoodRegime> FoodRegimes { get; set; }
        public virtual ICollection<PhilosophySchool> PhilosophySchools { get; set; }
       
        [ForeignKey("ApplicationUserFK")]
        
        public ApplicationUser applicationUser { get; set; }
        //public string ApplicationUserFK { get; set; }
    }
}
