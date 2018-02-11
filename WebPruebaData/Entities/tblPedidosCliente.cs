namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPedidosCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPedidosCliente()
        {
            tblEntregasCuentas = new HashSet<tblEntregasCuenta>();
        }

        [Key]
        public int idPedidoCliente { get; set; }

        public int? idUsuario { get; set; }

        public int? idCaja { get; set; }

        public int? idCliente { get; set; }

        public int? idFormaComunicacion { get; set; }

        public DateTime? FechaPedido { get; set; }

        [StringLength(50)]
        public string Equipo { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioInformado { get; set; }

        public int? idEstadoPedido { get; set; }

        public DateTime? FechaEstado { get; set; }

        public int? idEstadoPedidoAnterior { get; set; }

        public DateTime? FechaEstadoAnterior { get; set; }

        public int? idSalidaCab { get; set; }

        [StringLength(1000)]
        public string DescripcionSolucion { get; set; }

        public bool? TicketCliente { get; set; }

        public bool? EtiquetaEquipo { get; set; }

        public virtual tblCaja tblCaja { get; set; }

        public virtual tblCliente tblCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntregasCuenta> tblEntregasCuentas { get; set; }

        public virtual tblEstadosPedido tblEstadosPedido { get; set; }

        public virtual tblEstadosPedido tblEstadosPedido1 { get; set; }

        public virtual tblFormaComunicacion tblFormaComunicacion { get; set; }

        public virtual tblSalidasCab tblSalidasCab { get; set; }

        public virtual tblUsuario tblUsuario { get; set; }
    }
}
