using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JayrideCodingChallenge.WebSite.Models
{
    public class Location
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }        

        [JsonPropertyName("state")]
        public string Region_name { get; set; }

        [JsonPropertyName("country")]
        public string Country_name { get; set; }

        [JsonPropertyName("postcode")]
        public string Zip { get; set; }

        
    }
}
