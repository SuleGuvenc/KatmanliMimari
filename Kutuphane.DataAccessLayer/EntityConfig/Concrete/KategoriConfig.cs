using Kutuphane.DataAccessLayer.EntityConfig.Abstract;
using Kutuphane.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccessLayer.EntityConfig.Concrete
{
    public class KategoriConfig:BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.HasIndex(p => p.KategoriAdi).IsUnique();//Kategori Adina gore tekil olacak
            
        }
    }
}
