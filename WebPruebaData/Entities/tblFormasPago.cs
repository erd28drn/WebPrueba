namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFormasPago")]
    public partial class tblFormasPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFormasPago()
        {
            tblEntradasCabs = new HashSet<tblEntradasCab>();
            tblEntregasCuentas = new HashSet<tblEntregasCuenta>();
            tblProveedores = new HashSet<tblProveedore>();
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int IdFormaPago { get; set; }

        [Required]
        [StringLength(30)]
        public string DesFormaPago { get; set; }

        public bool? UsarEnCaja { get; set; }

        public bool? PredetCaja { get; set; }

        public bool? ActivaFormaPago { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImgActivo { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImgInactivo { get; set; }

        public bool? Efectivo { get; set; }

        public int? IdCuenta { get; set; }

        public bool? CtaEnFactura { get; set; }

        public virtual tblCuenta tblCuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradasCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntregasCuenta> tblEntregasCuentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedore> tblProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }
    }
}
