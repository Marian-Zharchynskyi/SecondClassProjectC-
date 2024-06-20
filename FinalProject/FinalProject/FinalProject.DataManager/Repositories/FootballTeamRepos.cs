using FinalProject.Core.Context;
using FinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManager.Repositories
{
    public class FootballTeamRepos
    {
        public IEnumerable<FootballTeam> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.FootballTeams.Include(x => x.Coach).ToList();
            }
        }

        public int Add(FootballTeam footballTeam)
        {
            using (var ctx = new FootballTeamContext())
            {
                var obj = ctx.FootballTeams.Add(footballTeam);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.FootballTeams.Remove(ctx.FootballTeams.Find(id));
                ctx.SaveChanges();
            }
        }
    }
}
