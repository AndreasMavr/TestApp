using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPP.Operations
{
    public interface IMatchOddDBO
    {
        Models.MatchOdds Get(int id);
        Models.MatchOdds Create(Models.MatchOdds matchodds);
        Models.MatchOdds Update(Models.MatchOdds matchodds);
        Models.MatchOdds Delete(Models.MatchOdds matchodds);
    }
}
