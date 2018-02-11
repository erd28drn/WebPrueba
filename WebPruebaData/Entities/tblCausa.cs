namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCausa
    {
        [Key]
        public int idCausa { get; set; }

        public int? idGrupo { get; set; }

        [StringLength(30)]
        public string DesCausa { get; set; }

        public virtual tblGrupos tblGrupos { get; set; }
    }
}
