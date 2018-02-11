namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCuenta()
        {
            tblEntradasCabs = new HashSet<tblEntradasCab>();
            tblFormasPagoes = new HashSet<tblFormasPago>();
            tblProveedores = new HashSet<tblProveedore>();
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int IdCuenta { get; set; }

        [StringLength(50)]
        public string DesCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string NumCuenta { get; set; }

        public int IdBanco { get; set; }

        public virtual tblBanco tblBanco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradasCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFormasPago> tblFormasPagoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedore> tblProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }
    }
}
