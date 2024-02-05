using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.ViewModels
{
    public class ShowUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RegisterDate { get; set; }
        public string IsActive { get; set; }
    }
    public class NameUser
    {
        public string Name { get; set; }
    }
}
