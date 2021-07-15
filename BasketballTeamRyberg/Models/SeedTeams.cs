using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasketballTeamRyberg.Models
{
    internal class SeedTeams : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> entity)
        {
            entity.HasData(
                new Team { TeamId = 1, Name = "Nets", Location = "Brooklyn"},
                new Team { TeamId = 2, Name = "Lakers", Location = "Los Angeles"},
                new Team { TeamId = 3, Name = "Heat", Location = "Miami"},
                new Team { TeamId = 4, Name = "Timberwolves", Location = "Minnesota"},
                new Team { TeamId = 5, Name = "Wizards", Location = "Washington"},
                new Team { TeamId = 6, Name = "Warriors", Location = "Golden State"},
                new Team { TeamId = 7, Name = "Grizzlies", Location = "Memphis"},
                new Team { TeamId = 8, Name = "Thunder", Location = "Oklahoma City"}
                );
        }
    }
}
