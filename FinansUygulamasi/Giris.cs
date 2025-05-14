using GelirGiderClass;
using System.Windows.Forms;

namespace FinansUygulamasiProjesi
{
    public partial class Giris : Form
    {
        //listeyi oluþtur
        private List<Kullanici> KullaniciListesi = new();
        public Giris()
        {
            InitializeComponent();
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = usernametxtbox.Text;
            string Sifre = passwtextbox.Text;

            //boþ giriþ kontrolü
            if (string.IsNullOrWhiteSpace(KullaniciAdi) || string.IsNullOrWhiteSpace(Sifre))
            {
                MessageBox.Show("Kullanýcý adý veya þifre boþ olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var dogruluk = KullaniciListesi.FirstOrDefault(k => k.KullaniciAdi == KullaniciAdi && k.Sifre == Sifre);
            if (dogruluk != null)
            {
                MessageBox.Show("Giriþ baþarýlý.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Program.GirisForm.Hide();
               Program.GelirGiderForm.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayitButonu_Click(object sender, EventArgs e)
        {
            //textboxtan verileri al
            string KullaniciAdi = usernametxtbox.Text;
            string Sifre = passwtextbox.Text;

            //boþ giriþ kontrolü
            if (string.IsNullOrWhiteSpace(KullaniciAdi) || string.IsNullOrWhiteSpace(Sifre))
            {
                MessageBox.Show("Kullanýcý adý veya þifre boþ olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //kullanýcý adý var mý kontrolü
            if (KullaniciListesi.Any(k => k.KullaniciAdi == KullaniciAdi))
            {
                MessageBox.Show("Bu kullanýcý adý zaten kayýtlý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //her þey doðruysa listeye ekle
            else { 
            KullaniciListesi.Add(new Kullanici(KullaniciAdi, Sifre));
            MessageBox.Show("Kayýt baþarýyla yapýlmýþtýr.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            usernametxtbox.Clear();
            passwtextbox.Clear();
        }
        

    }
}
