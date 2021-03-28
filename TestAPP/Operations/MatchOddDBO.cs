using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPP.Models;

namespace TestAPP.Operations
{
    public class MatchOddDBO : IMatchOddDBO
    {
        private readonly ContextMatchDb contextMatchDb;

        public MatchOddDBO(ContextMatchDb contextMatchDb)
        {
            this.contextMatchDb = contextMatchDb;
        }

        public MatchOdds Create(MatchOdds matchodds)
        {
            var response = contextMatchDb.Add(new Models.MatchOdds { MatchId = matchodds.MatchId, Specifier = matchodds.Specifier, Odd = matchodds.Odd });
            contextMatchDb.SaveChanges();
            return response.Entity;
        }

        public MatchOdds Delete(MatchOdds matchodd)
        {
            var response = contextMatchDb.Remove(matchodd);
            contextMatchDb.SaveChanges();
            return response.Entity;
        }

        public MatchOdds Get(int id)
        {
            return (MatchOdds)contextMatchDb.MatchOdds.Where(m => m.ID == id).FirstOrDefault();
        }

        public MatchOdds Update(MatchOdds matchodd)
        {
            var response = contextMatchDb.Update(matchodd);
            contextMatchDb.SaveChanges();
            return response.Entity;
        }
    }
}
