namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSalidasDet")]
    public partial class tblSalidasDet
    {
        [Key]
        public int idSalidaDet { get; set; }

        public int? idSalidaCab { get; set; }

        public int? idProducto { get; set; }

        [StringLength(256)]
        public string ObservDetalle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioVenta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVAProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DescuentoProducto { get; set; }

        public virtual tblProducto tblProducto { get; set; }

        public virtual tblSalidasCab tblSalidasCab { get; set; }
    }
}
