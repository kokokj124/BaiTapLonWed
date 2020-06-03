namespace BaiTapLon.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BaiTapLon.Models.Entity;

    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=BaiTapLon")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .Property(e => e.Size)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
            .Property(e => e.Email)
            .IsFixedLength();
        }
    }
}
