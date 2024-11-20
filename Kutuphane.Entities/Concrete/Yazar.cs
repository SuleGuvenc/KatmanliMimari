using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Concrete
{
    public class Yazar:BaseEntity
    {

        public string Adi { get; set; }
        public string Soyadi  { get; set; }
        public string? Email { get; set; }
        public string? Gsm { get; set; }
        public ICollection<Adres>? Adresler { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
