namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblConceptos")]
    public partial class tblConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblConcepto()
        {
            tblEntradasCabs = new HashSet<tblEntradasCab>();
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int idConcepto { get; set; }

        [StringLength(50)]
        public string DesConcepto { get; set; }

        public bool? Entrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradasCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }
    }
}
