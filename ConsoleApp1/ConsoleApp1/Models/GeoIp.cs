using Nest;

namespace ConsoleApp1.Models
{
    public class GeoIp
    {
        [Text(Name = "country_iso_code")]
        public string ISOCode { get; set; }

        public Location Location { get; set; }

        [Text(Name = "region_name")]
        public string Region { get; set; }

        [Text(Name = "continent_name")]
        public string Continent { get; set; }

        [Text(Name = "city_name")]
        public string City { get; set; }
    }
}
