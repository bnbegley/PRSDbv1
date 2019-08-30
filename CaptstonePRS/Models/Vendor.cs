using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaptstonePRS.Models
{
    public class Vendor
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Code { get; set;}
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [MaxLength(30)]
        [Required]
        public string City { get; set; }
        [MaxLength(2)]
        [Required]
        public string State { get; set; }
        [MaxLength(5)]
        [Required]
        public string Zip { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }

    }
}
