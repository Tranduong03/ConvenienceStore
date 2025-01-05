using GroceryStore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.OtherProcess
{
    internal class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-5JQDFU6J;Initial Catalog=FlashShopC#;Persist Security Info=True;User ID=sa;Password=bao123689;Encrypt=True;Trust Server Certificate=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<ImportDetail> ImportDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BillDetail>()
        //        .HasKey(bd => new { bd.BillId, bd.ProductID }); // Định nghĩa khóa chính tổng hợp

        //    base.OnModelCreating(modelBuilder);
        //}
        //public override int SaveChanges()
        //{
        //    // Xử lý trước khi lưu
        //    foreach (var entry in ChangeTracker.Entries<Bill>().Where(e => e.State == EntityState.Added))
        //    {
        //        entry.Entity.BillCode = "FLBill" + entry.Entity.BillId;
        //    }

        //    return base.SaveChanges();
        //}
    }
}
