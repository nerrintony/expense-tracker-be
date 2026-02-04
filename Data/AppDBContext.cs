using ExpenseTrackerBE.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ExpenseTrackerBE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
}
