using Nest;

namespace ConsoleApp1.Models
{
    public class Product
    {
        [Number(Name = "base_price")]
        public double BasePrice { get; set; }

        [Number(Name = "discound_percentage")]
        public double DiscoundPercentage { get; set; }

        public int Quantity { get; set; }

        public string Manufacturer { get; set; }

        [Number(Name = "tax_amount")]
        public double TaxAmount { get; set; }

        [Number(Name = "product_id")]
        public int ProductId { get; set; }

        public string Category { get; set; }

        public string Sku { get; set; }

        [Number(Name = "taxless_price")]
        public double TaxlessPrice { get; set; }

        [Number(Name = "unit_discound_amount")]
        public double UnitDiscoundAmount { get; set; }

        [Number(Name = "min_price")]
        public double MinPrice { get; set; }

        [Number(Name = "discount_amount")]
        public double DiscoundAmount { get; set; }

        [Date(Name = "created_on")]
        public DateTime CreatedOn { get; set; }

        [Text(Name = "product_name")]
        public string ProductName { get; set; }

        public double Price { get; set; }

        [Number(Name = "taxful_price")]
        public double TaxfulPrice { get; set; }

        [Number(Name = "base_unit_price")]
        public double BaseUnitPrice { get; set; }
    }
}
