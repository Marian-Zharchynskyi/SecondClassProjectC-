using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace FinalProject.Core.Entities
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool IsCaptain { get; set; }
        public string WorkingLeg { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public virtual ICollection<PlayerContract> PlayerContracts { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<PlayerTransfer> PlayerTransfers { get; set; }

        public override string ToString()
        {
            return
            $" ID: {Id}," + 
            $" Full name: {FullName}," +
            $" Age: {Age}," +
            $" Is captain: {IsCaptain}," +
            $" Working leg: {WorkingLeg}," +
            $" Goals scored: {Goals}," +
            $" Assists scored: {Assists}"; 
        }

        public string Name()
        {
            return $"{FullName}";
        }
    }
}
