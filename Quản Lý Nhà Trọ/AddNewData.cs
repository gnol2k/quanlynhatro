namespace Quản_Lý_Nhà_Trọ
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AddNewData : DbContext
    {
        public AddNewData()
            : base("name=AddNewData")
        {
        }

        public virtual DbSet<CTHOPDONG> CTHOPDONGs { get; set; }
        public virtual DbSet<ThuChi> ThuChis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHOPDONG>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOPDONG>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOPDONG>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<ThuChi>()
                .Property(e => e.MaTC)
                .IsUnicode(false);
        }
    }
}
