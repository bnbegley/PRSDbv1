using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaptstonePRS.Models

{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(30)]
        [Required]
        public string Password { get; set; }
        [MaxLength(30)]
        [Required]
        public string Firstname { get; set; }
        [MaxLength(30)]
        [Required]
        public string Lastname { get; set; }
        [MaxLength(12)]     
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public bool IsReviewer { get; set; }
        [Required]
        public bool IsAdmin { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
