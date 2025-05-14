using GelirGiderClass;

namespace GelirGiderClass
{
    public class Kullanici //burada nesnenin constructor'ı ve özellikleri(properties) oluşturulur.
    {
        public string KullaniciAdi { get; set; } //properties
        public string Sifre { get; set; }

        public Kullanici(string KullaniciAdi, string Sifre) //constructor
        {
            this.KullaniciAdi = KullaniciAdi;
            this.Sifre = Sifre;
        }
    }
}
