using JayrideCodingChallenge.WebSite.Models;
using JayrideCodingChallenge.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JayrideCodingChallenge.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        public CandidateController(CandidateService candidateService)
        {
            this.CandidateService = candidateService;
        }

        public CandidateService CandidateService { get; }

        // GET api/Candidate
        [HttpGet]
        public IEnumerable<Candidate> Get()
        {
            return CandidateService.GetCandidate();
        }
    }
}
