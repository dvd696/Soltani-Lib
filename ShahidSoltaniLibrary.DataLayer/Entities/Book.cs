using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Entities
{
    public class Book
    {
        public Book()
        {
            
        }

        [Key]
        public int BookId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int RemainNumber { get; set; }
        [Required]
        public bool CanLoan { get; set; }
        [Required]
        public string Floor { get; set; }
        [Required]
        public string Shelf { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; } = DateTime.Now;


        #region Navigation Property

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public List<UserBook> UserBooks { get; set; }

        #endregion
    }
}
