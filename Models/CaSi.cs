namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaSi")]
    public partial class CaSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaSi()
        {
            Album = new HashSet<Album>();
            BaiHat = new HashSet<BaiHat>();
        }

        [Key]
        public int MaCaSi { get; set; }

        [Required]
        [StringLength(255)]
        public string TenCaSi { get; set; }

        [StringLength(255)]
        public string AnhDaiDien { get; set; }

        [Column(TypeName = "text")]
        public string TieuSu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHat> BaiHat { get; set; }
    }
}
