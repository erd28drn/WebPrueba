namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblGrupos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGrupos()
        {
            tblCausas = new HashSet<tblCausa>();
            tblDetallesGrupos = new HashSet<tblDetallesGrupos>();
            tblProductos = new HashSet<tblProducto>();
            tblProductos1 = new HashSet<tblProducto>();
            tblProductos2 = new HashSet<tblProducto>();
            tblSubgrupos = new HashSet<tblSubgrupos>();
        }

        [Key]
        public int idGrupo { get; set; }

        public int? idTipoGrupo { get; set; }

        [StringLength(50)]
        public string desGrupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVAGrupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Margen { get; set; }

        public bool? Venta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCausa> tblCausas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDetallesGrupos> tblDetallesGrupos { get; set; }

        public virtual tblTiposGrupos tblTiposGrupos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubgrupos> tblSubgrupos { get; set; }
    }
}
