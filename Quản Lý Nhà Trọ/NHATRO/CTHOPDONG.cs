namespace Quản_Lý_Nhà_Trọ.NHATRO
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
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }

        public double? TIENCOC { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public DateTime? NGAYHETHAN { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
