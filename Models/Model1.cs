namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelMusic")
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<BaiHat> BaiHat { get; set; }
        public virtual DbSet<CaSi> CaSi { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaSi>()
                .Property(e => e.TieuSu)
                .IsUnicode(false);

            modelBuilder.Entity<CaSi>()
                .HasMany(e => e.BaiHat)
                .WithRequired(e => e.CaSi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.BaiHat)
                .WithRequired(e => e.TheLoai)
                .WillCascadeOnDelete(false);
        }
    }
}
