using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Loading_DataAnnotations
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        // Eğer veritabanı oluşturulurken hazır örnek veriler içermesini istiyorsak veritabanına seed data vermek zorundayız veritabanına seed data verebilmemiz için override onModelCreating yapmak zorundayız.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer() { CustomerId = 1, Name = "Berkay" },
                new Customer() { CustomerId = 2, Name = "Orçun" },
                new Customer() { CustomerId = 3, Name = "Eray" }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order() { OrderId = 1, Number = 5, CustomerId = 1 },
                new Order() { OrderId = 2, Number = 6, CustomerId = 1 },
                new Order() { OrderId = 3, Number = 7, CustomerId = 2 },
                new Order() { OrderId = 4, Number = 8, CustomerId = 3 },
                new Order() { OrderId = 5, Number = 9, CustomerId = 3 }
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server=.;database=YZL8101EFCoreIntro2;uid=sa;pwd=1234;trustservercertificate=true;").UseLazyLoadingProxies();
        }
    }
}
