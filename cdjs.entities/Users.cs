using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cdjs.entities
{
    public class Users
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.Member;
    }
}
