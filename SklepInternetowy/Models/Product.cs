using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy.Models
{
    public class Product
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = "";
        [MaxLength(50)]
        public string Brand { get; set; } = "";
        [MaxLength(50)]
        public string Category { get; set; } = "";
        [Precision(16,2)]
        public decimal Price { get; set; }

        public string Description { get; set; } = "";
        [MaxLength(50)]
        public string ImageFileName { get; set; } = "";
        
        public DateTime CreatedAt { get; set; }

    }
}
