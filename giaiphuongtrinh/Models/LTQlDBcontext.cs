using giaiphuongtrinh.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiNgay7hang9.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
           .Property(e => e.Usename)
           .IsUnicode(false);
            modelBuilder.Entity<Account>().Property(e => e.Password)
            .IsUnicode(false);
            modelBuilder.Entity<Khachhang>()
          .Property(e => e.MaKH)
          .IsUnicode(false);

        }
    }
}