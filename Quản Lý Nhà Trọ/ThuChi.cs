namespace Quản_Lý_Nhà_Trọ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuChi")]
    public partial class ThuChi
    {
        [Key]
        [StringLength(10)]
        public string MaTC { get; set; }

        [StringLength(10)]
        public string Loai { get; set; }

        [StringLength(100)]
        public string ChuThich { get; set; }

        public double? Phi { get; set; }

        public DateTime? NgayTC { get; set; }
    }
}
