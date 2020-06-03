namespace BaiTapLon.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public int? Price { get; set; }

        [StringLength(10)]
        public string Size { get; set; }

        [StringLength(250)]
        public string Details { get; set; }

        public int? SL { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string ShoeFirm { get; set; }
    }
}
