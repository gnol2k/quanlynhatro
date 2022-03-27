namespace Quản_Lý_Nhà_Trọ.NHATRO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANGTHIETBI")]
    public partial class TRANGTHIETBI
    {
        [Key]
        [StringLength(10)]
        public string MaTTB { get; set; }

        [StringLength(50)]
        public string TenTB { get; set; }

        public double? ChiPhi { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
