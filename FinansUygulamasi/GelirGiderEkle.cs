using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GelirGiderClass;

namespace FinansUygulamasiProjesi
{
    public partial class GelirGiderEkle : Form
    {

        public static List<GelirGider> GelirListesi = new();
        public static List<GelirGider> GiderListesi = new();
        public GelirGiderEkle()
        {
            InitializeComponent();
        }

        private void GelirGiderEkle_GeriButonu_MouseEnter(object sender, EventArgs e)
        {
            GelirGiderEkle_GeriButonu.BorderStyle = BorderStyle.FixedSingle;  // kenarlık ekleme
            GelirGiderEkle_GeriButonu.Refresh(); // ui update hızlansın
        }
        private void GelirGiderEkle_GeriButonu_MouseLeave(object sender, EventArgs e)
        {
            GelirGiderEkle_GeriButonu.BorderStyle = BorderStyle.None;  // kenarlık kaldırma
            GelirGiderEkle_GeriButonu.Refresh(); // ui update hızlansın
        }
        private void GelirGiderEkle_IleriButonu_MouseEnter(object sender, EventArgs e)
        {
            GelirGiderEkle_IleriButonu.BorderStyle = BorderStyle.FixedSingle;  // kenarlık ekleme
            GelirGiderEkle_IleriButonu.Refresh(); // ui update hızlansın
        }

        private void GelirGiderEkle_IleriButonu_MouseLeave(object sender, EventArgs e)
        {
            GelirGiderEkle_IleriButonu.BorderStyle = BorderStyle.None;  // kenarlık kaldırma
            GelirGiderEkle_IleriButonu.Refresh(); // ui update hızlansın
        }

        private void GelirGiderEkle_GeriButonu_Click(object sender, EventArgs e)
        {
            Program.GelirGiderForm.Hide();
            Program.GirisForm.Show();
        }

        private void GelirGiderEkle_IleriButonu_Click(object sender, EventArgs e)
        {
            Program.GelirGiderForm.Hide();
            Program.GelirGiderTabloForm.Show();

        }

        private void GelirEkle_btn_Click(object sender, EventArgs e)
        {
            string Tur = "Gelir";
            if (!HataKontrolleri())
            {
                return;  // hata varsa fonksiyondan çık, listeye ekleme yapma
            }
            string Kaynak = Kaynak_txtbox.Text;
            decimal.TryParse(Miktar_txtbox.Text, out decimal Miktar); //atamayı burada bir daha yapmak zorunda kaldım (hata alıyordum)
            DateTime Tarih = TarihSecici.Value.Date;


            GelirListesi.Add(new GelirGider(Tur, Miktar, Tarih, Kaynak)); // her şey doğruysa listeye ekle
            MessageBox.Show("Gelir eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gelir_combobox.DataSource = null; // data source sıfırla
            Gelir_combobox.DataSource = GelirListesi; // combobox'a listeden verileri geçirme
            Gelir_combobox.DisplayMember = "Kaynak"; //comboboxta gelirin kaynağını göster




        }

        private void GiderEkle_btn_Click(object sender, EventArgs e)
        {
            string Tur = "Gider";
            if (!HataKontrolleri())
            {
                return;  // hata varsa fonksiyondan çık, listeye ekleme yapma
            }
            string Kaynak = Kaynak_txtbox.Text;
            decimal.TryParse(Miktar_txtbox.Text, out decimal Miktar); //atamayı burada bir daha yapmak zorunda kaldım (hata alıyordum)
            DateTime Tarih = TarihSecici.Value.Date;

            GiderListesi.Add(new GelirGider(Tur, Miktar, Tarih, Kaynak)); // her şey doğruysa listeye ekle
            MessageBox.Show("Gider eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gider_combobox.DataSource = null; // data source sıfırla
            Gider_combobox.DataSource = GiderListesi; // combobox'a listeden verileri geçirme
            Gider_combobox.DisplayMember = "Kaynak"; //comboboxta giderin kaynağını göster

        }
        private bool HataKontrolleri()
        {

            if (string.IsNullOrWhiteSpace(Miktar_txtbox.Text) || string.IsNullOrWhiteSpace(Kaynak_txtbox.Text)) //textboxların boş kalmadığını kontrol et
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(Miktar_txtbox.Text, out decimal Miktar) || Miktar <= 0) //miktar sayı mı girilmiş kontrol et
            {
                MessageBox.Show("Miktar pozitif sayılar olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(Kaynak_txtbox.Text) || !Kaynak_txtbox.Text.All(Char.IsLetter)) //kaynağın yazıdan oluştuğunu kontrol et
            {
                MessageBox.Show("Kaynak, sayılardan oluşamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void GelirGiderSil_btn_Click(object sender, EventArgs e)
        {
           
            {
                GelirGider secilenGelirGider = null;

                // gelir combobox'tan seçilen öğeyi kontrol et
                if (Gelir_combobox.SelectedItem != null && Gider_combobox.SelectedItem == null)
                {
                    secilenGelirGider = Gelir_combobox.SelectedItem as GelirGider;
                }
                // gider combobox'tan öğe seçilmiş mi kontrol et
                else if (Gider_combobox.SelectedItem != null && Gelir_combobox.SelectedItem == null)
                {
                    secilenGelirGider = Gider_combobox.SelectedItem as GelirGider;
                }
                else
                {
                    MessageBox.Show("Silmek için yalnızca bir tane gelir veya gider seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // her iki combobox'ta seçilmişse uyarı göster
                    return;
                }

                // Eğer seçilen öğe null değilse, silme işlemine devam et
                if (secilenGelirGider != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Eğer Gelir ise
                        if (secilenGelirGider.Tur == "Gelir")
                        {
                            GelirListesi.Remove(secilenGelirGider);
                            Gelir_combobox.DataSource = null;
                            Gelir_combobox.DataSource = GelirListesi;
                            Gelir_combobox.DisplayMember = "Kaynak"; // Kaynak özelliğini göster
                        }
                        // Eğer Gider ise
                        else if (secilenGelirGider.Tur == "Gider")
                        {
                            GiderListesi.Remove(secilenGelirGider);
                            Gider_combobox.DataSource = null;
                            Gider_combobox.DataSource = GiderListesi;
                            Gider_combobox.DisplayMember = "Kaynak"; // Kaynak özelliğini göster
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir gelir veya gider seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        }
    }








