using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Entities
{
    public class User
    {
        public User()
        {

        }

        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        [Required]
        public bool IsActive { get; set; } = false;

        #region Navigation Property



        #endregion
    }
}
