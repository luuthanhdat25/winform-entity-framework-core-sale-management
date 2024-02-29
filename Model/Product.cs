using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Winform.Model
{
    [Table("Product")]
    public class Product
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
