namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSeriesFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSeriesFactura()
        {
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int idSerieFactura { get; set; }

        [StringLength(3)]
        public string NomSerieFactura { get; set; }

        [StringLength(30)]
        public string DescSerieFactura { get; set; }

        public bool? Contabiliza { get; set; }

        public bool? Entrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }

        public virtual tblSeriesFactura tblSeriesFacturas1 { get; set; }

        public virtual tblSeriesFactura tblSeriesFactura1 { get; set; }
    }
}
