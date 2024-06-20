using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Core.Entities
{
    public class Coach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int WonTrofies { get; set; }
        public int CurrentMatchesAmount { get; set; }
        public int WonMatches { get; set; }
        public int LoosedMatches {  get; set; }
        public int DrawnMatches { get; set; }
        public virtual ICollection<CoachContract> CoachContracts { get; set; }
        public virtual ICollection<FootballTeam> FootballTeams { get; set; }

        public override string ToString()
        {
            return
            $" ID: {Id}," +
            $" Full name: {FullName}," +
            $" Age: {Age}," +
            $" Won trofies: {WonTrofies}," +
            $" Current matches amount: {CurrentMatchesAmount}," +
            $" Won matches: {WonMatches}," +
            $" Loosed matches: {LoosedMatches}," +
            $" Drawn matches: {DrawnMatches},";
        }

        public string Name()
        {
            return $"{FullName}";
        }
    }
}
