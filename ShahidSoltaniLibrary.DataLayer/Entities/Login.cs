using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Entities
{
    public class Login
    {
        public Login()
        {

        }

        [Key]
        public int LoginId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
