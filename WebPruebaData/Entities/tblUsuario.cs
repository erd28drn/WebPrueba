namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuario()
        {
            tblEntregasCuentas = new HashSet<tblEntregasCuenta>();
            tblPedidosClientes = new HashSet<tblPedidosCliente>();
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(20)]
        public string NombreUsuario { get; set; }

        [StringLength(50)]
        public string NombreCompletoUsuario { get; set; }

        [StringLength(24)]
        public string ClaveUsuario { get; set; }

        public bool? AdminUsuario { get; set; }

        public bool? ActivoUsuario { get; set; }

        public bool? UltimoUsuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntregasCuenta> tblEntregasCuentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPedidosCliente> tblPedidosClientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }
    }
}
