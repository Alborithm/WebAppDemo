using System;

using System.Collections.Generic;
using System.Configuration;

namespace Data
{
    public class MysqlDbContext
    {
        // public MysqlDbContext(DbContextOptions<MysqlDbContext> options)
        //  : base(options)
        // {
        // }
        // public DbSet<Characters> Characters { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {            
        //     // optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=Alboria;user=root;");
        //     // optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString);
        // }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        // base.OnModelCreating(modelBuilder);

        // modelBuilder.Entity<Characters>(entity =>
        // {
        //     entity.HasKey(e => e.Id);
        //     entity.Property(e => e.CharName).IsRequired();
        // });   
        // }
    }
}