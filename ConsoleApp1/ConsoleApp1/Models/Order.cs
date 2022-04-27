using Nest;

namespace ConsoleApp1.Models
{
    public class Order
    {
        public IEnumerable<string> Category { get; set; }

        [Keyword]
        public string Currency { get; set; }

        [Text(Name = "customer_first_name")]
        public string FirstName { get; set; }

        [Text(Name = "customer_full_name")]
        public string FullName { get; set; }

        [Keyword(Name = "customer_gender")]
        public string Gender { get; set; }

        [Keyword(Name = "customer_id")]
        public int Id { get; set; }

        [Text(Name = "customer_last_name")]
        public string LastName { get; set; }

        [Keyword(Name = "customer_phone")]
        public string Phone { get; set; }

        [Text(Name = "day_of_week")]
        public string DayOfWeek { get; set; }

        [Number(Name = "day_of_week_i")]
        public int DayOfWeekNumber { get; set; }

        [Keyword]
        public string Email { get; set; }

        public IEnumerable<string> Manufacturer { get; set; }

        [Date(Name = "order_date")]
        public DateTime OrderDate { get; set; }

        [Number(Name = "order_id")]
        public int OrderId { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<string> Sku { get; set; }

        [Number(Name = "taxful_total_price")]
        public double TaxfulTotalPrice { get; set; }

        [Number(Name = "taxless_total_price")]
        public double TaxlessTotalPrice { get; set; }

        [Number(Name = "total_quantity")]
        public int TotalQuantity { get; set; }

        [Number(Name = "total_unique_products")]
        public int TotalUniqueProducts { get; set; }

        public string Type { get; set; }

        public string User { get; set; }

        [PropertyName("geoip")]
        public GeoIp GeoIp { get; set; }

        public Event Event { get; set; }
    }
}
