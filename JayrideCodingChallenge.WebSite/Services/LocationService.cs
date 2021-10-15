using JayrideCodingChallenge.WebSite.Models;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace JayrideCodingChallenge.WebSite.Services
{
    public class LocationService
    { 
        public static Location GetLocation(string ipAddress)
        {
            //Get the response from ipstack.com
            var t = Task.Run(() => CommonService.GetByUri(new Uri(GetUriString(ipAddress))));
            t.Wait();
            return JsonConvert.DeserializeObject<Location>(t.Result);
        }
        public static string GetUriString(string ipAddress)
        {
            return string.Format(Startup.StaticConfig["LocationApiUrl"], ipAddress);
        }
    }
}
