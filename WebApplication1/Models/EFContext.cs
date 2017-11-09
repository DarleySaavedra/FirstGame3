
    using global::WebApplication1.Models;
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    namespace WebApplication1.Models
    {
        public class EFContext : DbContext
        {
            public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<RegisterViewModel> Register { get; set; }


        public EFContext()
                : base("name=EFContext")
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions
                    .Remove<PluralizingTableNameConvention>();
                #region
                modelBuilder.Entity<Pregunta>()
                    .Property(x => x.pregunta)
                    .HasMaxLength(200)
                    .IsRequired();
                #endregion

                #region
                modelBuilder.Entity<Pregunta>()
                    .Property(x => x.opt1)
                    .HasMaxLength(200)
                    .IsRequired();
                #endregion


                #region
                modelBuilder.Entity<Pregunta>()
                    .Property(x => x.opt2)
                    .HasMaxLength(200)
                    .IsRequired();
                #endregion


                #region
                modelBuilder.Entity<Pregunta>()
                    .Property(x => x.opt3)
                    .HasMaxLength(200)
                    .IsRequired();
                #endregion


                #region
                modelBuilder.Entity<Pregunta>()
                    .Property(x => x.opt4)
                    .HasMaxLength(200)
                    .IsRequired();
                #endregion
            }

        }

        //public class MyEntity
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}
    }
