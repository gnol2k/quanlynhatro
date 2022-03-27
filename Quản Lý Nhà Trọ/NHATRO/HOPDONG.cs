namespace Quản_Lý_Nhà_Trọ.NHATRO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(50)]
        public string TenHD { get; set; }

        [StringLength(20)]
        public string TINHTRANG { get; set; }

        [StringLength(300)]
        public string GHICHU { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaCT { get; set; }

        public virtual CHUTRO CHUTRO { get; set; }

        public virtual CTHOPDONG CTHOPDONG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
