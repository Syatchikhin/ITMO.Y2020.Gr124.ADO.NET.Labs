namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gas.Composition")]
    public partial class Composition
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string compositionName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string componentFormula { get; set; }

        public decimal componentVolume { get; set; }
    }
}
