using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstGas
{
        public class GasContext : DbContext
        {
            public GasContext() : base("MyTestGas")
            { }

            public DbSet<Composition> Compositions { get; set; }
            public DbSet<Mixture> Mixtures { get; set; }
            public DbSet<Component> Components { get; set; }
            public DbSet<Element> Elements { get; set; }
        }

        //public partial class Property
        public partial class Mixture
        {
        [Key]
        public string gasName { get; set; }
        public Composition gasMixture { get; set; }
        public string gasPath { get; set; }
        public Nullable<short> gasSize { get; set; }
        public Nullable<decimal> gasDensity { get; set; }
        public Nullable<decimal> gasConstant { get; set; }

        public override string ToString()
        {
            string s = gasName;
            return s;
        }
    }

    public partial class Composition
    {
        [Key]
        public string compositionName { get; set; }
        public string componentFormula { get; set; }
        public decimal componentVolume { get; set; }

        public override string ToString()
        {
            string s = compositionName;
            return s;
        }

    }

    public partial class Component
    {
        public short componentNumber { get; set; }
        [Key]
        public string componentName { get; set; }
        public string componentNameRu { get; set; }
        public string componentFormula { get; set; }
        public decimal componentMolarWeignt { get; set; }

        public override string ToString()
        {
            string s = componentName;
            return s;
        }


    }

    public partial class Element
    {
        [Key]
        public string elementName { get; set; }
        public decimal elementAtomicWeight { get; set; }

        public override string ToString()
        {
            string s = elementName;
            return s;
        }


    }

    public class Model
    {
    }
}
