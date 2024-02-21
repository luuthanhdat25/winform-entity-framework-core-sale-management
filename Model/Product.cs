using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Product")]
    public class Product
    {
        [Key] [Required]
        public int ProductId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(40)] 
        public string? ProductName { get; set; }

        [Required]
        [StringLength(20)] 
        public string? Weight { get; set; }

        [Required]
        [Column(TypeName = "money")] 
        public decimal UnitPrice { get; set; }

        [Required]
        public int UnitInStock { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
