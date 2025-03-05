namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiBao")]
    public partial class BaiBao
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string tieu_de { get; set; }

        [Required]
        public string noi_dung { get; set; }

        public int? tac_gia_id { get; set; }

        public DateTime? ngay_dang { get; set; }

        public virtual TacGia TacGia { get; set; }
    }
}
