namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDireccionesCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDireccionesCliente()
        {
            tblSalidasCabs = new HashSet<tblSalidasCab>();
        }

        [Key]
        public int idDirCliente { get; set; }

        public int? idCliente { get; set; }

        [StringLength(30)]
        public string AliasDirCliente { get; set; }

        [StringLength(50)]
        public string NomDirCliente { get; set; }

        [StringLength(15)]
        public string NIF { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        public int? idPoblacion { get; set; }

        [StringLength(20)]
        public string FijoCliente { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string MovilCliente { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        public virtual tblCliente tblCliente { get; set; }

        public virtual tblPoblacione tblPoblacione { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidasCab> tblSalidasCabs { get; set; }
    }
}
