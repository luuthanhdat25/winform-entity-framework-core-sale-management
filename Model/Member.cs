﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winform.Model
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
