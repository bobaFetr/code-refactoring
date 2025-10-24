using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Stock.Models
{
    public class Stock
    {
        public Stock()
        {
            Id = Guid.NewGuid().ToString();
            Name = string.Empty;
            Description = string.Empty;
            Price = "0";
            Quantity = "0";
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("Product name")]
        public String Name { get; set; }

        [Required]
        [Comment("Quantity in stock")]
        public string Quantity { get; set; } = "0";

        [Required]
        [MaxLength(1_000)]
        [Comment("Product description")]
        public string Description { get; set; }

        [Required]
        [Comment("Price in unknown currency")]
        public string Price { get; set; }
    }
}