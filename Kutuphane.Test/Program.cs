using Kutuphane.DataAccessLayer.Contexts;
using Kutuphane.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace Kutuphane.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            //Yazar orhan = new Yazar() { Adi = "Orhan", Soyadi = "Pamuk" };
            //Kitap kitap = new Kitap() { KitapAdi = "KaraKitap" };
            //kitap.Yazarlar = new List<Yazar>();

            //kitap.Yazarlar.Add(orhan);

            #region Sinirsiz kırılimli kategori kayit giris
            List<Kategori> kategoriler = new();

            Kategori k = new Kategori() { KategoriAdi = "Gida" };
            kategoriler.Add(k);
            k = new Kategori() { KategoriAdi = "Tekstil" };
            kategoriler.Add(k);
            k= new Kategori() { KategoriAdi = "Eglence" };
            kategoriler.Add(k);

            context.Kategoriler.AddRange(kategoriler);

            context.SaveChanges();
            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}