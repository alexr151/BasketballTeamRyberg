using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        [Required(ErrorMessage = "Please enter a team name")]
        [StringLength(200)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a location")]
        [StringLength(200)]
        [Remote("CheckLocation", "Validation", "", AdditionalFields = "Location, Operation")]
        public string Location { get; set; }

        public string TeamName => $"{Location} {Name}";

        public ICollection<TeamPlayer> TeamPlayers { get; set; }

    }
}
