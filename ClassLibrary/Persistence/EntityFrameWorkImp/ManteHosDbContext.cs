using System;
using System.Data.Entity;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using ManteHos.Entities;

namespace ManteHos.Persistence
{
    public class ManteHosDbContext : DbContextISW
    {
        public ManteHosDbContext() : base("Name=ManteHosDbConnection")
        {
            // OBLIGATORIO: Permite que funcionen las relaciones y la carga diferida
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

     
            static ManteHosDbContext()
            {
                // CAMBIO IMPORTANTE: Usamos 'DropCreateDatabaseAlways' para forzar el arreglo
                // Una vez te funcione, puedes volver a poner 'IfModelChanges'
                Database.SetInitializer<ManteHosDbContext>(new DropCreateDatabaseAlways<ManteHosDbContext>());
            }
        

        // DbSets (Tablas)
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<UsedPart> UsedParts { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }

        // AQUÍ ESTÁ EL ARREGLO DE LA TABLA INTERMEDIA
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuración de fechas
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));

            // --- ESTO ES LO QUE FALTABA PARA QUE SE GUARDEN LOS OPERARIOS ---
            modelBuilder.Entity<WorkOrder>()
                .HasMany(w => w.Operators)
                .WithMany(o => o.WorkOrders)
                .Map(m =>
                {
                    m.ToTable("WorkOrderOperators"); // Crea la tabla de unión
                    m.MapLeftKey("WorkOrderId");
                    m.MapRightKey("OperatorId");
                });
            // ----------------------------------------------------------------

            base.OnModelCreating(modelBuilder);
        }

        public override void RemoveAllData()
        {
            base.RemoveAllData();
        }
    }
}