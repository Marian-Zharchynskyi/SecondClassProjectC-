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
   public  class PlayerRep
    {
        public IEnumerable<Player> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.Players.ToList();
            }
        }

        public int Add(Player player)
        {
            using (var ctx = new FootballTeamContext())
            {
                var obj = ctx.Players.Add(player);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.Players.Remove(ctx.Players.Find(id));
                ctx.SaveChanges();
            }
        }
    }
}
