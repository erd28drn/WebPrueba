namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEntradasDet")]
    public partial class tblEntradasDet
    {
        [Key]
        public int idEntradaDet { get; set; }

        public int? idEntradaCab { get; set; }

        public int? idProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVAProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IRPF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DescuetoProducto { get; set; }

        [StringLength(256)]
        public string ObservDetalle { get; set; }

        public virtual tblEntradasCab tblEntradasCab { get; set; }

        public virtual tblProducto tblProducto { get; set; }
    }
}
