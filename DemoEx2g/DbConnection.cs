using DemoEx2g.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx2g
{
    public class DbConnection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=demo431;Username=postgres;Password=123");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }   
        public DbSet<Order> Orders { get; set; }
        public DbSet<PickupPoint> PickupPoint { get; set; }
    }
}
