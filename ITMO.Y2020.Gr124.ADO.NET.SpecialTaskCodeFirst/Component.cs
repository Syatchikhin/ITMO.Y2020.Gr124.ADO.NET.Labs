namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Media.Components")]
    public partial class Component
    {
        public short componentNumber { get; set; }

        [Key]
        [StringLength(25)]
        public string componentName { get; set; }

        [Required]
        [StringLength(25)]
        public string componentNameRu { get; set; }

        [Required]
        [StringLength(10)]
        public string componentFormula { get; set; }

        public decimal componentMolarWeignt { get; set; }
    }
}
