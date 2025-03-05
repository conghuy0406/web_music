namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            BaiHat = new HashSet<BaiHat>();
        }

        [Key]
        public int MaAlbum { get; set; }

        [Required]
        [StringLength(255)]
        public string TenAlbum { get; set; }

        public int MaCaSi { get; set; }

        [StringLength(255)]
        public string AnhBia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPhatHanh { get; set; }

        public virtual CaSi CaSi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHat> BaiHat { get; set; }
    }
}
