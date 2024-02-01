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
        public int BookId { get; set; }
        [Required]
        public int LoanId { get; set; }

        #region Navigation Property

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        [ForeignKey(nameof(LoanId))]
        public Loan Loan { get; set; }

        #endregion
    }
}
