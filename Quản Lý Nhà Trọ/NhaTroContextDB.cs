namespace Quản_Lý_Nhà_Trọ
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NhaTroContextDB : DbContext
    {
        public NhaTroContextDB()
            : base("name=NhaTroContextDB1")
        {
        }

        public virtual DbSet<CHUTRO> CHUTROes { get; set; }
        public virtual DbSet<CTHOPDONG> CTHOPDONGs { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUVUCPHONG> KHUVUCPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUTRO>()
                .Property(e => e.MaCT)
                .IsUnicode(false);

            modelBuilder.Entity<CHUTRO>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<CHUTRO>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOPDONG>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOPDONG>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MaCT)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.CTHOPDONGs)
                .WithRequired(e => e.HOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHUVUCPHONG>()
                .Property(e => e.MaKV)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MaKV)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CTHOPDONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);
        }
    }
}
