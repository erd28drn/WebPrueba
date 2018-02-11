namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDondeNosConocio")]
    public partial class tblDondeNosConocio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDondeNosConocio()
        {
            tblClientes = new HashSet<tblCliente>();
        }

        [Key]
        public int idDonde { get; set; }

        [StringLength(30)]
        public string DesDonde { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCliente> tblClientes { get; set; }
    }
}
