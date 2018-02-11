namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSubgrupos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSubgrupos()
        {
            tblProductos = new HashSet<tblProducto>();
            tblProductos1 = new HashSet<tblProducto>();
            tblProductos2 = new HashSet<tblProducto>();
        }

        [Key]
        public int idSubgrupo { get; set; }

        public int? idGrupo { get; set; }

        [StringLength(50)]
        public string desSubgrupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Margen { get; set; }

        public bool? Venta { get; set; }

        public bool? ControlaStock { get; set; }

        public int? idColumna { get; set; }

        public virtual tblColumnasLibroGasto tblColumnasLibroGasto { get; set; }

        public virtual tblGrupos tblGrupos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos2 { get; set; }
    }
}
