using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Concrete
{
    public class Adres:BaseEntity
    {
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? CaddeSokak { get; set; }

        public int YazarId { get; set; }

        //Navigation Property
        public Yazar? Yazar { get; set; }
    }
}
