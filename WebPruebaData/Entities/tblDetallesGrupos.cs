namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDetallesGrupos
    {
        [Key]
        public int idDetalleGrupo { get; set; }

        public int? idGrupo { get; set; }

        public int? idDetalle { get; set; }

        public virtual tblDetalle tblDetalle { get; set; }

        public virtual tblGrupos tblGrupos { get; set; }
    }
}
