namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblProvincia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProvincia()
        {
            tblPoblaciones = new HashSet<tblPoblacione>();
        }

        [Key]
        public int idprovincia { get; set; }

        [Required]
        [StringLength(30)]
        public string provincia { get; set; }

        [StringLength(3)]
        public string provincia3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPoblacione> tblPoblaciones { get; set; }
    }
}
