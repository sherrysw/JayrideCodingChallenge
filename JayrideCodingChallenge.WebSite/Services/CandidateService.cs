using JayrideCodingChallenge.WebSite.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JayrideCodingChallenge.WebSite.Services
{
    public class CandidateService
    {
        public CandidateService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            //Get the path of the /data/Candidate.json
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Candidate.json"); }
        }

        public IEnumerable<Candidate> GetCandidate()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Candidate[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
