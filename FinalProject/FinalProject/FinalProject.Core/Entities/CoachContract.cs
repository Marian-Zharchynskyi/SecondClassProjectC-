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
    public class CoachContract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Coach Coach { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return
            $" ID: {Id}," +
            $" Coach name: {Coach.Name()}," +
            $" Start date: {StartDate.ToString("yyyy-MM-dd")}," +
            $" End date: {EndDate.ToString("yyyy-MM-dd")}," +
            $" Salary: {Salary}";
        }
    }
}
