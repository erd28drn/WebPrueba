namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCliente()
        {
            tblDireccionesClientes = new HashSet<tblDireccionesCliente>();
            tblPedidosClientes = new HashSet<tblPedidosCliente>();
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreCliente { get; set; }

        [StringLength(20)]
        public string TelCliente { get; set; }

        public int? idDonde { get; set; }

        [StringLength(1000)]
        public string ObsCliente { get; set; }

        public bool? ActivoCliente { get; set; }

        public virtual tblDondeNosConocio tblDondeNosConocio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDireccionesCliente> tblDireccionesClientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPedidosCliente> tblPedidosClientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }
    }
}
