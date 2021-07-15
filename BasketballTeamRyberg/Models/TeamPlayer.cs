using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    public class TeamPlayer
    {
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public Team Team { get; set; }
        public Player Player { get; set; }
    }
}
