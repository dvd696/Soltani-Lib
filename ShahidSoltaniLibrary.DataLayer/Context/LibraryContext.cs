using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.DataLayer.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryContext")
        {

        }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Login> Login { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<UserBook> UserBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
