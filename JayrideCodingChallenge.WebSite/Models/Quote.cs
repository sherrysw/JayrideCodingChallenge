using System.Collections.Generic;

namespace JayrideCodingChallenge.WebSite.Models
{
    public class Quote
    {
        public string From { get; set; }

        public string To { get; set; }

        public List<QuoteListing> Listings { get; set; }

    }

    public class QuoteListing
    {
        public decimal TotalPrice { get; set; }
        public string Name { get; set; }

        public decimal PricePerPassenger { get; set; }

        public VehicleType VehicleType { get; set; }       

    }

    public class VehicleType
    {
        public string Name { get; set; }

        public int MaxPassengers { get; set; }
    }
}
