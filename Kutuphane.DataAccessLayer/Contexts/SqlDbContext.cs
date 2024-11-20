using Kutuphane.DataAccessLayer.EntityConfig.Concrete;
using Kutuphane.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccessLayer.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Kategori>   Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }

        // dotnet ef komutu bos constructer ister
        public SqlDbContext()
        {

        }

        //Bu kisim IOC Container icerisine register edilirken kullanilacak
        public SqlDbContext(DbContextOptions<SqlDbContext> options):base(options)
        {
            
        }


        //Burasi kullanilacak 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Kutuphane;Trusted_Connection=true;TrustServerCertificate=true");
        }

        //Elimizdeki Entity'lerin property'lerini configure etmemiz icin gerekli metod
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);

            

            

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
