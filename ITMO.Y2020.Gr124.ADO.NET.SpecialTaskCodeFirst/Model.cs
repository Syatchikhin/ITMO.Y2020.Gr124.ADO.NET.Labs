namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=MyGasModel")
        {
        }

        public virtual DbSet<Composition> Compositions { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Element> Elements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Composition>()
                .Property(e => e.compositionName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Composition>()
                .Property(e => e.componentFormula)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Composition>()
                .Property(e => e.componentVolume)
                .HasPrecision(9, 6);

            modelBuilder.Entity<Property>()
                .Property(e => e.gasName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.gasDencity)
                .HasPrecision(6, 3);

            modelBuilder.Entity<Property>()
                .Property(e => e.gasConstant)
                .HasPrecision(6, 3);

            modelBuilder.Entity<Property>()
                .Property(e => e.gasPath)
                .IsFixedLength();

            modelBuilder.Entity<Component>()
                .Property(e => e.componentName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Component>()
                .Property(e => e.componentNameRu)
                .IsFixedLength();

            modelBuilder.Entity<Component>()
                .Property(e => e.componentFormula)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Component>()
                .Property(e => e.componentMolarWeignt)
                .HasPrecision(9, 6);

            modelBuilder.Entity<Element>()
                .Property(e => e.elementName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Element>()
                .Property(e => e.elementAtomicWeight)
                .HasPrecision(9, 6);
        }
    }
}
