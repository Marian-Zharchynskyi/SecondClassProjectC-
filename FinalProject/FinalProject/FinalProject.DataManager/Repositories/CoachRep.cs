using FinalProject.Core.Context;
using FinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManager.Repositories
{
    public class CoachRep
    {
        public IEnumerable<Coach> GetAll()
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.Coaches.ToList();
            }
        }

        public int Add(Coach coach)
        {
            using (var ctx = new FootballTeamContext())
            {
                var obj = ctx.Coaches.Add(coach);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public void Update(Coach updCoach)
        {
            using (var ctx = new FootballTeamContext())
            {
                var coach = ctx.Coaches.Find(updCoach.Id);

                if (coach.FullName != updCoach.FullName)
                {
                    coach.FullName = updCoach.FullName;
                    ctx.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                ctx.Coaches.Remove(ctx.Coaches.Find(id));
                ctx.SaveChanges();
            }
        }

    }
}
