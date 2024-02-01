using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Entities
{
    public class Loan
    {
        public Loan()
        {

        }

        [Key]
        public int LoanId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public bool Finish { get; set; } = false;
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }


        #region Navigation Property

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public List<UserBook> UserBooks { get; set; }

        #endregion
    }
}
