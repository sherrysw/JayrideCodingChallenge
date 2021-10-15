using JayrideCodingChallenge.WebSite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayrideCodingChallenge.WebSite.Services
{
    public class QuoteService
    {
        public static List<QuoteListing> GetQuote(int passengersCount)
        {
            //Get the response from JayrideChallengeApi
            var t = Task.Run(() => CommonService.GetByUri(new Uri(Startup.StaticConfig["JayrideChallengeApi"])));
            t.Wait();
            //Convert the result to Quote
            Quote quotes = JsonConvert.DeserializeObject<Quote>(t.Result);
            //Filter the Listings
            List<QuoteListing> filteredList = quotes.Listings.FindAll(l => l.VehicleType.MaxPassengers >= passengersCount);            
            foreach (var list in filteredList)
            {
                //Calculate the TotalPrice for each Listing
                list.TotalPrice = list.PricePerPassenger * passengersCount;
            }
            //Sort the listing by TotalPrice
            List<QuoteListing> SortedList = filteredList.OrderBy(o => o.TotalPrice).ToList();
            return SortedList;
        } 
    }
}
