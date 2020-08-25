using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstGas
{
        public class GasContext : DbContext
        {
            public GasContext() : base("Gas5")
            { }

            public DbSet<Gas> Gases { get; set; }
            public DbSet<Mixture> Mixtures { get; set; }
            public DbSet<Component> Components { get; set; }
            public DbSet<Element> Elements { get; set; }

        //Composite PK for Mixture
        protected override void OnModelCreating( DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mixture>().HasKey(u => new { u.gasName, u.componentName });
        }


    }

    //    //public partial class Property
    public partial class Gas
    {
        [Key]
        public string gasName { get; set; }
        public Nullable<short> gasSize { get; set; }
        public Nullable<decimal> gasDensity { get; set; }
        public Nullable<decimal> gasConstant { get; set; }
        public string path { get; set; }

        public ICollection<Mixture> Mixtures { get; set; }

        public Gas()
        {
            Mixtures = new List<Mixture>();
        }
    }

    public partial class Mixture
    {
        public string gasName { get; set; }
        public string componentName { get; set; }
        public decimal volume { get; set; }

        public Component Component { get; set; } // one-to -one
        public override string ToString()
        {
            string s = gasName;
            return s;
        }

    }

    public partial class Component
    {
        //public short componentNumber { get; set; }
        [Key]
        [ForeignKey("MixtureOf")]
        public string componentName { get; set; }
        public string componentNameRu { get; set; }
        public string componentFormula { get; set; }
        public decimal componentMW { get; set; }

        public Mixture MixtureOf { get; set; } // for one-to -one
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
        public decimal elementAW { get; set; }

        public override string ToString()
        {
            string s = elementName;
            return s;
        }


    }

        //public class Model
        //{
        //}
}
