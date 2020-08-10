namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Media.Elements")]
    public partial class Element
    {
        [Key]
        [StringLength(2)]
        public string elementName { get; set; }

        public decimal elementAtomicWeight { get; set; }
    }
}
