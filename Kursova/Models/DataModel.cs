namespace Kursova.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<cars> cars { get; set; }
        public virtual DbSet<checks> checks { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<details> details { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<guarantee> guarantee { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cars>()
                .Property(e => e.firm_name)
                .IsUnicode(false);

            modelBuilder.Entity<cars>()
                .Property(e => e.car_model)
                .IsUnicode(false);

            modelBuilder.Entity<cars>()
                .Property(e => e.engine_power)
                .HasPrecision(10, 4);

            modelBuilder.Entity<cars>()
                .Property(e => e.flow_consumption)
                .HasPrecision(10, 4);

            modelBuilder.Entity<cars>()
                .Property(e => e.gasoline_consumption)
                .HasPrecision(10, 4);

            modelBuilder.Entity<cars>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.cars)
                .HasForeignKey(e => e.car_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.clients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<details>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<details>()
                .Property(e => e.price)
                .HasPrecision(10, 4);

            modelBuilder.Entity<details>()
                .HasMany(e => e.checks)
                .WithRequired(e => e.details)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.salary)
                .HasPrecision(10, 4);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.comm)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.summ)
                .HasPrecision(10, 4);

            modelBuilder.Entity<orders>()
                .Property(e => e.guarantee)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.gos_number)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .HasMany(e => e.checks)
                .WithRequired(e => e.orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orders>()
                .HasMany(e => e.guarantee1)
                .WithRequired(e => e.orders)
                .WillCascadeOnDelete(false);
        }
    }
}
