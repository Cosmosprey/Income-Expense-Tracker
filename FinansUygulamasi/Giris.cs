using GelirGiderClass;
using System.Windows.Forms;

namespace FinansUygulamasiProjesi
{
    public partial class Giris : Form
    {
        //listeyi olu�tur
        private List<Kullanici> KullaniciListesi = new();
        public Giris()
        {
            InitializeComponent();
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = usernametxtbox.Text;
            string Sifre = passwtextbox.Text;

            //bo� giri� kontrol�
            if (string.IsNullOrWhiteSpace(KullaniciAdi) || string.IsNullOrWhiteSpace(Sifre))
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo� olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var dogruluk = KullaniciListesi.FirstOrDefault(k => k.KullaniciAdi == KullaniciAdi && k.Sifre == Sifre);
            if (dogruluk != null)
            {
                MessageBox.Show("Giri� ba�ar�l�.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Program.GirisForm.Hide();
               Program.GelirGiderForm.Show();
                
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayitButonu_Click(object sender, EventArgs e)
        {
            //textboxtan verileri al
            string KullaniciAdi = usernametxtbox.Text;
            string Sifre = passwtextbox.Text;

            //bo� giri� kontrol�
            if (string.IsNullOrWhiteSpace(KullaniciAdi) || string.IsNullOrWhiteSpace(Sifre))
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo� olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //kullan�c� ad� var m� kontrol�
            if (KullaniciListesi.Any(k => k.KullaniciAdi == KullaniciAdi))
            {
                MessageBox.Show("Bu kullan�c� ad� zaten kay�tl�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //her �ey do�ruysa listeye ekle
            else { 
            KullaniciListesi.Add(new Kullanici(KullaniciAdi, Sifre));
            MessageBox.Show("Kay�t ba�ar�yla yap�lm��t�r.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            usernametxtbox.Clear();
            passwtextbox.Clear();
        }
        

    }
}
