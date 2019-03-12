using beeFit2019.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Data
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<User> Users{ get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
    }
}
