namespace BaiTapLon.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaiTapLonContext : DbContext
    {
        public BaiTapLonContext()
            : base("name=BaiTapLonContext")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .Property(e => e.Size)
                .IsFixedLength();
        }
    }
}
