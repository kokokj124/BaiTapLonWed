namespace BaiTapLon.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase2")
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
