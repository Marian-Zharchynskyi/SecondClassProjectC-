using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;

namespace FinalProject.Core.Entities
{
    public class FootballTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Country { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual ICollection<PlayerContract> PlayerContracts { get; set; }

        public override string ToString()
        {
            return
            $" ID: {Id}," +
            $" Full name: {FullName}," +
            $" Creation date: {CreationDate.ToString("yyyy-MM-dd")}," +
            $" Country team: {Country}," +
            $" Coach name: {Coach.Name()}";
        }

        public string Name()
        {
            return $"{FullName}";
        }
    }

}
