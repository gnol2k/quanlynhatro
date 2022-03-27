namespace Quản_Lý_Nhà_Trọ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            CTHOPDONGs = new HashSet<CTHOPDONG>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaCT { get; set; }

        public double? TienCoc { get; set; }

        public DateTime? NGAYHETHAN { get; set; }

        public DateTime? NGAYLAP { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        public virtual CHUTRO CHUTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOPDONG> CTHOPDONGs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
