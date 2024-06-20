using FinalProject.Core.Context;
using FinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManager.Repositories
{
     public class CoachContractRep
    {
        public IEnumerable<CoachContract> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.CoachContracts.Include(x => x.Coach).ToList();
            }
        }

        public int Add(CoachContract coachContract)
        {
            using (var ctx = new FootballTeamContext())
            {
                var obj = ctx.CoachContracts.Add(coachContract);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public CoachContract Get(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.CoachContracts.Find(id);
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.CoachContracts.Remove(ctx.CoachContracts.Find(id));
                ctx.SaveChanges();
            }
        }


    }
}
