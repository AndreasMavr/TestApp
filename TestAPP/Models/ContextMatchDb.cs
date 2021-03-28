using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPP.Models
{
    public class ContextMatchDb : DbContext
    {
        private readonly string connectionString;

        public ContextMatchDb(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchOdds> MatchOdds { get; set; }

        
        public ContextMatchDb(DbContextOptions options) : base(options)
        {

        }
    }
}
