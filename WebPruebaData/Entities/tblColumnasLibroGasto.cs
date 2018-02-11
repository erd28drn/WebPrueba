namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblColumnasLibroGastos")]
    public partial class tblColumnasLibroGasto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblColumnasLibroGasto()
        {
            tblSubgrupos = new HashSet<tblSubgrupos>();
        }

        [Key]
        public int idColumna { get; set; }

        [StringLength(50)]
        public string NombreColumna { get; set; }

        public int? PosicionColumna { get; set; }

        public bool? Inversion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubgrupos> tblSubgrupos { get; set; }
    }
}
