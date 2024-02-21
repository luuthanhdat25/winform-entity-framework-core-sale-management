using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
    public class Member
    {
        [Key]
        [Required]
        public int MemberId { get; set; }

        [Required] 
        [StringLength(100)]         
        public string? Email { get; set; }

        [Required]
        [StringLength(40)] 
        public string? CompanyName { get; set; }

        [Required]
        [StringLength(15)]
        public string? City { get; set; }

        [Required]
        [StringLength(15)]
        public string? Country { get; set; }

        [Required] 
        [StringLength(30)] 
        public string? Password { get; set; }
    }
}
