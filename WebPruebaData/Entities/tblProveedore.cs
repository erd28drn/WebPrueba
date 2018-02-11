namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblProveedore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProveedore()
        {
            tblEntradasCabs = new HashSet<tblEntradasCab>();
        }

        [Key]
        public int IdProveedor { get; set; }

        public int? NumProveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string DesProveedor { get; set; }

        [Required]
        [StringLength(20)]
        public string DNINIFProveedor { get; set; }

        [StringLength(100)]
        public string DirProveedor { get; set; }

        public int? IdPoblacion { get; set; }

        [StringLength(100)]
        public string DirFiscalProveedor { get; set; }

        public int? IdPobFiscal { get; set; }

        [StringLength(30)]
        public string TelProveedor { get; set; }

        [StringLength(20)]
        public string FaxProveedor { get; set; }

        [StringLength(20)]
        public string CelProveedor { get; set; }

        [StringLength(50)]
        public string EmailProveedor { get; set; }

        [StringLength(50)]
        public string WebProveedor { get; set; }

        [StringLength(50)]
        public string NomContacto { get; set; }

        [StringLength(20)]
        public string TelContacto { get; set; }

        [StringLength(50)]
        public string EmailContacto { get; set; }

        public int? CredProveedor { get; set; }

        public int? IdFormaPago { get; set; }

        public int? IdCuenta { get; set; }

        [StringLength(255)]
        public string ObsProveedor { get; set; }

        public bool? ActivoProveedor { get; set; }

        public virtual tblCuenta tblCuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradasCab> tblEntradasCabs { get; set; }

        public virtual tblFormasPago tblFormasPago { get; set; }

        public virtual tblPoblacione tblPoblacione { get; set; }

        public virtual tblPoblacione tblPoblacione1 { get; set; }
    }
}
