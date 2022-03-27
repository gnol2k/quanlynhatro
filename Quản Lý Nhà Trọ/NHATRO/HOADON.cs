namespace Quản_Lý_Nhà_Trọ.NHATRO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(10)]
        public string MADV { get; set; }

        public double? TIENPHONG { get; set; }

        public double? TIENDIEN { get; set; }

        public double? TIENNUOC { get; set; }

        public double? TONGTIEN { get; set; }

        public DateTime? THOIGIAN { get; set; }

        [StringLength(500)]
        public string GHICHU { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
