namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEstadosPedidos")]
    public partial class tblEstadosPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEstadosPedido()
        {
            tblPedidosClientes = new HashSet<tblPedidosCliente>();
            tblPedidosClientes1 = new HashSet<tblPedidosCliente>();
        }

        [Key]
        public int idEstadoPedido { get; set; }

        [StringLength(50)]
        public string desEstadoPedido { get; set; }

        public bool? Satisfactorio { get; set; }

        public int? Orden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPedidosCliente> tblPedidosClientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPedidosCliente> tblPedidosClientes1 { get; set; }
    }
}
