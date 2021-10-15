using JayrideCodingChallenge.WebSite.Models;
using JayrideCodingChallenge.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace JayrideCodingChallenge.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        // GET api/Location/{ipAddress}
        [HttpGet("{ipAddress}")]
        public Location Get(string ipAddress)
        {
            return LocationService.GetLocation(ipAddress);            
        }

    }
}
