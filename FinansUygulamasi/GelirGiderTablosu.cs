using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansUygulamasiProjesi
{
    public partial class GelirGiderTablosu : Form
    {
        private BindingSource gelirBindingSource = new BindingSource();
        private BindingSource giderBindingSource = new BindingSource();
        public GelirGiderTablosu()
        {
            InitializeComponent();
        }
        private void GelirGiderTablosu_GeriButonu_MouseEnter(object sender, EventArgs e)
        {
            GelirGiderTablosu_GeriButonu.BorderStyle = BorderStyle.None;  // kenarlık kaldırma
            GelirGiderTablosu_GeriButonu.Refresh(); // ui update hızlansın
        }

        private void GelirGiderTablosu_GeriButonu_MouseLeave(object sender, EventArgs e)
        {
            GelirGiderTablosu_GeriButonu.BorderStyle = BorderStyle.None;  // kenarlık kaldırma
            GelirGiderTablosu_GeriButonu.Refresh(); // ui update hızlansın
        }
       

        private void GelirGiderTablosu_GeriButonu_Click(object sender, EventArgs e)
        {
            Program.GelirGiderTabloForm.Hide();
            Program.GelirGiderForm.Show();
        }

        private void GelirGiderYazdir_btn_Click(object sender, EventArgs e)
        {
            GelirVeGiderleriGoster();
        }
        private void GelirVeGiderleriGoster()
        {
            var GelirVeGiderler = GelirGiderEkle.GelirListesi.Concat(GelirGiderEkle.GiderListesi).ToList();
            GelirGiderTablosu_datagridview.DataSource = GelirVeGiderler;
            decimal ToplamGelir = 0;
            // gelir listesini topla
            foreach (var gelir in GelirGiderEkle.GelirListesi)
            {
                ToplamGelir += gelir.Miktar;
            }
            toplamgelir_lbl.Text = $"Toplam Gelir: {ToplamGelir}";

            decimal ToplamGider = 0;
            // gelir listesini topla
            foreach (var gider in GelirGiderEkle.GiderListesi)
            {
                ToplamGider += gider.Miktar;
            }
            toplamgider_lbl.Text = $"Toplam Gider: {ToplamGider}";

            decimal AySonuDurum = ToplamGelir - ToplamGider;
            aysonudurum_lbl.Text = $"Ay Sonu Durum: {AySonuDurum}";
        }
    }
}

