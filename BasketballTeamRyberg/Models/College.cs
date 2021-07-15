using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    public class College
    {
        [StringLength(10)]
        [Required(ErrorMessage ="Please enter a college id")]
        [Remote("CheckCollege", "Validtion", "")]
        public string CollegeId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="Please enter a college name")]
        public string CollegeName { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
