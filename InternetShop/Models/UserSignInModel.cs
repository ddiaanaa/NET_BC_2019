using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Ludzu ievadiet epastu!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Nepareizais datu tips")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ludzu ievadiet paroli! Minimums 8 zimes.")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
