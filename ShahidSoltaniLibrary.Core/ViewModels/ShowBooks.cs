using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.ViewModels
{
    public class ShowBooks
    {
        public ShowBooks()
        {
            
        }

        [Required]
        public int BookId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int NumberOfRemain { get; set; }
        [Required]
        public string CanLoan { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
