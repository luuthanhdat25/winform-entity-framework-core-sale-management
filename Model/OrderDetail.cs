using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Model
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
