using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Winform.Model
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime RequiredDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Freight { get; set; }

        public Order(int orderId, int member, DateTime orderDate, DateTime requiredDate, DateTime? shippedDate, decimal freight)
        {
            OrderId = orderId;
            MemberId = member;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            Freight = freight;
        }

        public Order()
        {
        }
    }
}
