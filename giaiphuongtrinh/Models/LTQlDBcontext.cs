using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace giaiphuongtrinh.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
           .Property(e => e.Usename)
           .IsUnicode(false);
            modelBuilder.Entity<Account>().Property(e => e.Password)
            .IsUnicode(false);
        }
    }

}