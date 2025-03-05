namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<BaiBao> BaiBao { get; set; }
        public virtual DbSet<TacGia> TacGia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.BaiBao)
                .WithOptional(e => e.TacGia)
                .HasForeignKey(e => e.tac_gia_id)
                .WillCascadeOnDelete();
        }
    }
}
