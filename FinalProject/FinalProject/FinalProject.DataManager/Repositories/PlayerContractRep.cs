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
    public class PlayerContractRep
    {
        public IEnumerable<PlayerContract> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.PlayerContracts.Include(x => x.Player).Include(x => x.Team).ToList();
            }
        }

        public int Add(PlayerContract playerContract)
        {
            using (var ctx = new FootballTeamContext())
            {
                var obj = ctx.PlayerContracts.Add(playerContract);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.PlayerContracts.Remove(ctx.PlayerContracts.Find(id));
                ctx.SaveChanges();
            }
        }
    }
}
