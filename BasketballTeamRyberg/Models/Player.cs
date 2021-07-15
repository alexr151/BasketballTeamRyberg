using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        
        [Required(ErrorMessage="Please enter a first name")]
        [StringLength(200)]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please enter a last name")]
        [StringLength(200)]
        [Remote("CheckPlayer", "Validation", "", AdditionalFields = "FirstName, Operation")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please select a college")]
        public string CollegeId { get; set; }
        public College College { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}
