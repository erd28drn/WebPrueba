namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEntregasCuenta
    {
        [Key]
        public int idEntregaCta { get; set; }

        public int? idUsuario { get; set; }

        public int? idCaja { get; set; }

        public int? idPedidoCliente { get; set; }

        public DateTime? FechaEntregaCta { get; set; }

        [StringLength(1000)]
        public string ObservEntregaCta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ImporteEntregado { get; set; }

        public int? idFormaPago { get; set; }

        public virtual tblCaja tblCaja { get; set; }

        public virtual tblFormasPago tblFormasPago { get; set; }

        public virtual tblPedidosCliente tblPedidosCliente { get; set; }

        public virtual tblUsuario tblUsuario { get; set; }
    }
}
