using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    internal class SeedPlayers : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> entity)
        {
            entity.HasData(
                new Player { PlayerId = 1, FirstName = "Devin", LastName = "Booker"},
                new Player { PlayerId = 2, FirstName = "Kevin", LastName = "Durant"},
                new Player { PlayerId = 3, FirstName = "Steph", LastName = "Curry"},
                new Player { PlayerId = 4, FirstName = "Draymond", LastName = "Green"},
                new Player { PlayerId = 5, FirstName = "Kade", LastName = "Wade"},
                new Player { PlayerId = 6, FirstName = "Lebron", LastName = "James"},
                new Player { PlayerId = 7, FirstName = "James", LastName = "Harden"},
                new Player { PlayerId = 8, FirstName = "Kyrie", LastName = "Irving"}
                );
        }
    }
}
