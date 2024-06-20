using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Entities
{
    public class PlayerTransfer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string TeamFrom {  get; set; }
        public string TeamTo { get; set; }
        public virtual Player Player { get; set; }
        public bool? FullFledged { get; set; }
        public bool? Rent { get; set; }
        public DateTime? DateRentStart { get; set; }
        public DateTime? DateRentEnd { get; set; }

        public override string ToString()
        {
            return
                $" ID: {Id}," +
                $" Price: {Price}," +
                $" Team from: {TeamFrom}," +
                $" Team to: {TeamTo}," +
                $" Player name: {Player?.Name() ?? "N/A"}," +
                $" Is it full fledged: {FullFledged ?? false}," +
                $" Is it rent: {Rent ?? false}," +
                $" Date contract start: {DateRentStart?.ToString("yyyy-MM-dd") ?? "N/A"}," +
                $" Date contract end: {DateRentEnd?.ToString("yyyy-MM-dd") ?? "N/A"},";
        }


    }
}
