namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDetallesProductos")]
    public partial class tblDetallesProducto
    {
        [Key]
        public int idDetalleProducto { get; set; }

        public int? idProducto { get; set; }

        public int? idDetalle { get; set; }

        [StringLength(30)]
        public string valorDetalle { get; set; }

        public virtual tblDetalle tblDetalle { get; set; }

        public virtual tblProducto tblProducto { get; set; }
    }
}
