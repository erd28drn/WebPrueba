namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPoblacione
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPoblacione()
        {
            tblDireccionesClientes = new HashSet<tblDireccionesCliente>();
            tblProveedores = new HashSet<tblProveedore>();
            tblProveedores1 = new HashSet<tblProveedore>();
        }

        [Key]
        public int IdPoblacion { get; set; }

        public int IdProvincia { get; set; }

        [Required]
        [StringLength(30)]
        public string poblacion { get; set; }

        [Required]
        [StringLength(5)]
        public string postal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDireccionesCliente> tblDireccionesClientes { get; set; }

        public virtual tblProvincia tblProvincia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedore> tblProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedore> tblProveedores1 { get; set; }
    }
}
