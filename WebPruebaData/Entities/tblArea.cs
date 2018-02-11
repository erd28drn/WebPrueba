namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblArea
    {
        [Key]
        public int idArea { get; set; }

        [StringLength(50)]
        public string desArea { get; set; }
    }
}
