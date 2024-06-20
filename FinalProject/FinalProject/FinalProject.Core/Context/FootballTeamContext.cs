using FinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Context
{
    public class FootballTeamContext: DbContext
    {
        public DbSet<Coach> Coaches => Set<Coach>();
        public DbSet<CoachContract> CoachContracts => Set<CoachContract>();
        public DbSet<FootballTeam> FootballTeams => Set<FootballTeam>();
        public DbSet<Player> Players => Set<Player>();
        public DbSet<PlayerContract> PlayerContracts => Set<PlayerContract>();
        public DbSet<PlayerTransfer> PlayerTransfers => Set<PlayerTransfer>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<User> Users => Set<User>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=.;Database=Football_Team;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
