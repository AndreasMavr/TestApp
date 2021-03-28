using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPP.Models
{
    [Table("MatchOdds")]
    public class MatchOdds
    {
        public int ID { get; set; }
        [Column("match_id")]
        public int MatchId { get; set; }
        [Column("specifier")]
        public string Specifier { get; set; }
        [Column("odd")]
        public float Odd { get; set; }
    }
}