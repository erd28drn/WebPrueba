namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFormaComunicacion")]
    public partial class tblFormaComunicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFormaComunicacion()
        {
            tblPedidosClientes = new HashSet<tblPedidosCliente>();
        }

        [Key]
        public int idFormaComunicacion { get; set; }

        [StringLength(30)]
        public string desFormaComunicacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPedidosCliente> tblPedidosClientes { get; set; }
    }
}
