using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MySqlCoreDemo.Data
{
    public class MyDbContext: DbContext 
    {
        public MyDbContext(DbContextOptions<MyDbContext>options): base(options) 
        {
            
        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(e => e.Property(o => o.age).HasColumnType("smallint").HasConversion<byte>());
            modelBuilder.Entity<Person>(e => e.Property(o => o.isPlayer).HasConversion(new BoolToZeroOneConverter<Int16>()).HasColumnType("bit"));
        }
    }
}
