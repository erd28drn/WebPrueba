namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStock")]
    public partial class tblStock
    {
        [Key]
        public int idStock { get; set; }

        public int? idProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Stock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioCosto { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }
    }
}
