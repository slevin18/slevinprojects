using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Models
{
    public class Login
    {
        [Key]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }
    }
}
