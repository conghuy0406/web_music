namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiHat")]
    public partial class BaiHat
    {
        [Key]
        public int MaBaiHat { get; set; }

        [Required]
        [StringLength(255)]
        public string TenBaiHat { get; set; }

        public int MaCaSi { get; set; }

        public int? MaAlbum { get; set; }

        public int MaTheLoai { get; set; }

        public TimeSpan ThoiLuong { get; set; }

        [Required]
        [StringLength(255)]
        public string DuongDanFile { get; set; }

        public int? LuotNghe { get; set; }

        public DateTime? NgayThem { get; set; }

        public virtual Album Album { get; set; }

        public virtual CaSi CaSi { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
