namespace Quản_Lý_Nhà_Trọ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHOPDONG")]
    public partial class CTHOPDONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public double? TIENCOC { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public DateTime? NGAYHETHAN { get; set; }

        [StringLength(10)]
        public string MAKH { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
