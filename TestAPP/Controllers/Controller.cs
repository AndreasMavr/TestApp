using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestAPP.Models;
using TestAPP.Operations;
using Match = TestAPP.Models.Match;

namespace TestAPP.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private IMatchDBO mdbo = null;
        private IMatchOddDBO modbo = null;
        public MatchController(IMatchDBO matchdbo, IMatchOddDBO matchodddbo)
        {
            mdbo = matchdbo;
            modbo = matchodddbo;
        }
        [HttpGet("Match/{id}")]
        public ActionResult<Match> GetMatch([FromRoute] int ID)
        {
            return mdbo.Get(ID);
        }

        [HttpPost("Match")]
        public ActionResult<Match> CreateMatch([FromBody] Match match)
        {
            return Ok(mdbo.Create(match));
        }

        [HttpPut("Match")]
        public ActionResult<Match> UpdateMatch([FromBody] Match match)
        {
            return Ok(mdbo.Update(match));
        }

        [HttpDelete("Match")]
        public ActionResult<Models.Match> DeleteMatch([FromBody] Match match)
        {
            return Ok(mdbo.Delete(match));
        }

        [HttpGet("MatchOdd/{id}")]
        public ActionResult<MatchOdds> GetMatchOdd([FromRoute] int ID)
        {
            return modbo.Get(ID);
        }

        [HttpPost("MatchOdd")]
        public ActionResult<MatchOdds> CreateMatchOdd([FromBody] MatchOdds matchodds)
        {
            return Ok(modbo.Create(matchodds));
        }

        [HttpPut("MatchOdd")]
        public ActionResult<MatchOdds> UpdateMatchOdd([FromBody] MatchOdds matchodds)
        {
            return Ok(modbo.Update(matchodds));
        }

        [HttpDelete("MatchOdd")]
        public ActionResult<MatchOdds> DeleteMatchOdd([FromBody] MatchOdds matchodds)
        {
            return Ok(modbo.Delete(matchodds));
        }
    }
}