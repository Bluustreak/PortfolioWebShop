using System.ComponentModel.DataAnnotations;

namespace PortfolioWebShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public short Rating{ get; set; }
        public List<ProductImage> ? ImagesList { get; set; }

        public Product(decimal price, short rating)
        {
            Price = price;
            Rating = rating;
            this.Brand = string.Empty;
        }
    }
}
