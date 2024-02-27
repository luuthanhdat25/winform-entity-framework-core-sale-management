using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Winform.Model
{
    [Keyless]
    internal class OrderDetail
    {
        [Required]
        public Order? Order{ get; set; }

        [Required]
        public Product? Product { get; set; }

        [Required]
        [Column(TypeName = "money")] 
        public decimal UnitPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Discount { get; set; }
    }
}
