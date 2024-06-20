using FinalProject.Core.Context;
using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManager.Repositories
{
    public class PositionRep
    {
        public IEnumerable<Position> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.Positions.ToList();
            }
        }

        public int Add(Position position)
        {
            using (var ctx = new FootballTeamContext())
            {
                var obj = ctx.Positions.Add(position);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.Positions.Remove(ctx.Positions.Find(id));
                ctx.SaveChanges();
            }
        }
    }
}
