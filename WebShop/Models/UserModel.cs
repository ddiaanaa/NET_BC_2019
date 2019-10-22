using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Ludzu ievadiet epastu!")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Nepareizais datu tips")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string PasswordRepeat { get; set; }
    }
}
