using Project1_WellnessApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_WellnessApp.Models
{
    public class FoodRegime
    {
        public int Id { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
