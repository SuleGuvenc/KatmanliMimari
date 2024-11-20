using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Concrete
{
    public class Kategori : BaseEntity
    {

        [MaxLength(50)] //Data Annotations yontemi 
        public string KategoriAdi { get; set; }

        public int? UstKategoriId { get; set; }
        public Kategori? UstKategori { get; set; }

        public ICollection<Kategori> AltKategoriler { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
