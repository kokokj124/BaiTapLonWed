namespace BaiTapLon.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Key]
        [StringLength(50)]
        public string Email { get; set; }

        public bool? Sex { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
