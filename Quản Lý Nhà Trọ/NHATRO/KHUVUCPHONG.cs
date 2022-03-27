namespace Quản_Lý_Nhà_Trọ.NHATRO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUVUCPHONG")]
    public partial class KHUVUCPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUVUCPHONG()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(10)]
        public string MaKV { get; set; }

        [StringLength(100)]
        public string TenKV { get; set; }

        [StringLength(300)]
        public string DiaChi { get; set; }

        public int? SLPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
