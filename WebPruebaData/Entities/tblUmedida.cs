namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUmedida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUmedida()
        {
            tblProductos = new HashSet<tblProducto>();
        }

        [Key]
        public int idUmedida { get; set; }

        [StringLength(4)]
        public string codUmedida { get; set; }

        [StringLength(30)]
        public string desUmedida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos { get; set; }
    }
}
