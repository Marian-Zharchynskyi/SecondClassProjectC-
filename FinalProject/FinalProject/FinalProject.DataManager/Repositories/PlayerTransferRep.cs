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
   public  class PlayerTransferRep
    {
        public IEnumerable<PlayerTransfer> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.PlayerTransfers.Include(x => x.Player).ToList();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.PlayerTransfers.Remove(ctx.PlayerTransfers.Find(id));
                ctx.SaveChanges();
            }
        }
    }
}
