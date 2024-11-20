using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Concrete
{
    public class Kitap:BaseEntity
    {

        public string KitapAdi { get; set; }
        public int? SayfaSayisi { get; set; }
        public ICollection<Kategori>? Kategoriler { get; set; }

        public ICollection<Yazar>? Yazarlar { get; set; }
        public Kitap()
        {

            Kategoriler = new HashSet<Kategori>();
            Yazarlar = new HashSet<Yazar>();

        }
    }
}
