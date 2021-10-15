using JayrideCodingChallenge.WebSite.Models;
using JayrideCodingChallenge.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JayrideCodingChallenge.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        // GET api/Quote/{passengersCount}
        [HttpGet("{passengersCount}")]
        public List<QuoteListing> Get(int passengersCount)
        {
            return QuoteService.GetQuote(passengersCount);
        }

      
    }
}
