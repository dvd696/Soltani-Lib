using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Entities
{
    public class UserBook
    {
        public UserBook()
        {
            
        }

        [Key]
        public int UB_Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int BookId { get; set; }

        #region Navigation Property

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        #endregion
    }
}
