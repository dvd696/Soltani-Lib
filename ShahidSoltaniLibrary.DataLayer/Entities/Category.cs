using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Entities
{
    public class Category
    {

        public Category()
        {
            
        }

        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Title { get; set; }


        #region Navigation Property

        public List<Book> Books { get; set; }

        #endregion
    }
}
