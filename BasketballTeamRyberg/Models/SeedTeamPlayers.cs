using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasketballTeamRyberg.Models
{
    internal class SeedTeamPlayers : IEntityTypeConfiguration<TeamPlayer>
    {
        public void Configure(EntityTypeBuilder<TeamPlayer> entity)
        {
            entity.HasData(
                new TeamPlayer { PlayerId = 1, TeamId = 1 },
                new TeamPlayer { PlayerId = 2, TeamId = 2},
                new TeamPlayer { PlayerId = 3, TeamId = 3 },
                new TeamPlayer { PlayerId = 4, TeamId = 4 },
                new TeamPlayer { PlayerId = 5, TeamId = 5 },
                new TeamPlayer { PlayerId = 6, TeamId = 6 },
                new TeamPlayer { PlayerId = 7, TeamId = 7 },
                new TeamPlayer { PlayerId = 8, TeamId = 8 }
                );
        }
    }
}
