using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPP.Models
{
    [Table("Match")]
    public class Match
    {
        public int ID { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("match_date")]
        public DateTime MatchDate { get; set; }
        [Column("match_time")]
        public DateTime MatchTime { get; set; }
        [Column("team_a")]
        public string TeamA { get; set; }
        [Column("team_b")]
        public string TeamB { get; set; }
        [Column("sport")]
        public int Sport { get; set; }
    }
}