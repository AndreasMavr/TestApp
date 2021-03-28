using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPP.Operations
{
    public interface IMatchDBO
    {
        Models.Match Get(int id);
        Models.Match Create(Models.Match match);
        Models.Match Update(Models.Match match);
        Models.Match Delete(Models.Match match);
    }
}
