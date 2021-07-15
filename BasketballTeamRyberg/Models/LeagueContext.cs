using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRyberg.Models
{
    public class LeagueContext : DbContext
    {
        public LeagueContext (DbContextOptions <LeagueContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public DbSet<College> Colleges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TeamPlayer: set composite primary key
            modelBuilder.Entity<TeamPlayer>().HasKey(tp => new { tp.TeamId, tp.PlayerId });

            //TeamPlayer: set foreign keys
            modelBuilder.Entity<TeamPlayer>().HasOne(tp => tp.Player)
                .WithMany(p => p.TeamPlayers)
                .HasForeignKey(p => p.PlayerId);

            modelBuilder.Entity<TeamPlayer>().HasOne(tp => tp.Team)
                .WithMany(t => t.TeamPlayers)
                .HasForeignKey(t => t.TeamId);

            //Player: remove cascading delete with College
            modelBuilder.Entity<Player>().HasOne(p => p.College)
                .WithMany(c => c.Players)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new SeedColleges());
            modelBuilder.ApplyConfiguration(new SeedTeams());
            modelBuilder.ApplyConfiguration(new SeedPlayers());
            modelBuilder.ApplyConfiguration(new SeedTeamPlayers());
        }
    }
}
