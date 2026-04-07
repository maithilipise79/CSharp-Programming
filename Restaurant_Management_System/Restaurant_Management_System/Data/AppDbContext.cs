using Microsoft.EntityFrameworkCore;
using Restaurant_Management_System.Entity.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> TblCustomer { get; set; }
        public DbSet<Delivery> TblDelivery { get; set; }
        public DbSet<Feedback> TblFeedback { get; set; }
        public DbSet<MenuItem> TblMenuItem { get; set; }
        public DbSet<Order> TblOrder { get; set; }
        public DbSet<Staff> TblStaff { get; set; }
        public DbSet<TableReservation> TblTableReservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MP\SQLEXPRESS;Database=RestaurantDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
