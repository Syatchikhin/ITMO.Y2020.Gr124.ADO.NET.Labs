namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gas.Properties")]
    public partial class Property
    {
        [Key]
        [StringLength(25)]
        public string gasName { get; set; }

        public short? gasSize { get; set; }

        public decimal? gasDencity { get; set; }

        public decimal? gasConstant { get; set; }

        [StringLength(40)]
        public string gasPath { get; set; }
    }



}
