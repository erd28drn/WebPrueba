namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEntradasCab")]
    public partial class tblEntradasCab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEntradasCab()
        {
            tblEntradasDets = new HashSet<tblEntradasDet>();
        }

        [Key]
        public int idEntradaCab { get; set; }

        public int? idUsuario { get; set; }

        public int? idCaja { get; set; }

        public int? idConcepto { get; set; }

        public bool? Devolucion { get; set; }

        public int? idEntradaDevuelta { get; set; }

        public int? idProveedor { get; set; }

        [StringLength(30)]
        public string NumeroFactura { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaFactura { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaVcto { get; set; }

        public int? idSerieFactura { get; set; }

        public int? idFormaPago { get; set; }

        public int? idCuenta { get; set; }

        [StringLength(256)]
        public string CopiaFactura { get; set; }

        [StringLength(1000)]
        public string Observaciones { get; set; }

        public bool? ImpresoEntrada { get; set; }

        public virtual tblCaja tblCaja { get; set; }

        public virtual tblConcepto tblConcepto { get; set; }

        public virtual tblCuenta tblCuenta { get; set; }

        public virtual tblFormasPago tblFormasPago { get; set; }

        public virtual tblProveedore tblProveedore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradasDet> tblEntradasDets { get; set; }
    }
}
