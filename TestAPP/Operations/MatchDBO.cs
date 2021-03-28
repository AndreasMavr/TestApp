using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPP.Models;

namespace TestAPP.Operations
{
    public class MatchDBO : IMatchDBO
    {
        private readonly ContextMatchDb contextMatchDb;

        public MatchDBO(ContextMatchDb contextMatchDb)
        {
            this.contextMatchDb = contextMatchDb;
        }

        public Match Create(Models.Match match)
        {
            var response = contextMatchDb.Add(new Models.Match { Description = match.Description, MatchDate = match.MatchDate, MatchTime = match.MatchTime, TeamA = match.TeamA, TeamB = match.TeamB, Sport = match.Sport });
            contextMatchDb.SaveChanges();
            return response.Entity;
        }

        public Match Delete(Match match)
        {
            var response = contextMatchDb.Remove(match);
            contextMatchDb.SaveChanges();
            return response.Entity;
        }

        public Match Get(int id)
        {
            return (Match)contextMatchDb.Matches.Where(m => m.ID == id).FirstOrDefault();
        }

        public Match Update(Match match)
        {
            var response = contextMatchDb.Update(match);
            contextMatchDb.SaveChanges();
            return response.Entity;
        }
    }
}
