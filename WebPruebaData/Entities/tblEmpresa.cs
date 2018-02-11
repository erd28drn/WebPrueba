namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmpresa
    {
        [Key]
        public int IdEmpresa { get; set; }

        [Required]
        [StringLength(20)]
        public string NIFEmpresa { get; set; }

        [StringLength(50)]
        public string NomComercial { get; set; }

        [Required]
        [StringLength(50)]
        public string DesEmpresa { get; set; }

        [StringLength(100)]
        public string DirEmpresa { get; set; }

        public int? IdPoblacion { get; set; }

        [StringLength(50)]
        public string TelEmpresa { get; set; }

        [StringLength(50)]
        public string CelEmpresa { get; set; }

        [StringLength(50)]
        public string FaxEmpresa { get; set; }

        [StringLength(50)]
        public string EmailEmpresa { get; set; }

        [StringLength(50)]
        public string WebEmpresa { get; set; }

        [StringLength(256)]
        public string DirImagEmpresa { get; set; }

        [StringLength(256)]
        public string DirCopiaTickets { get; set; }

        public bool? ActivoEmpresa { get; set; }

        [Column(TypeName = "image")]
        public byte[] LogoEmpresa { get; set; }

        [Column(TypeName = "image")]
        public byte[] LogoTickets { get; set; }

        [Column(TypeName = "image")]
        public byte[] LogoReducido { get; set; }
    }
}
