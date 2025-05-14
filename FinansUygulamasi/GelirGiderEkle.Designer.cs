namespace FinansUygulamasiProjesi
{
    partial class GelirGiderEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirGiderEkle));
            Kaynak_lbl = new Label();
            Miktar_lbl = new Label();
            Tarih_lbl = new Label();
            Kaynak_txtbox = new TextBox();
            Miktar_txtbox = new TextBox();
            TarihSecici = new DateTimePicker();
            GelirEkle_btn = new Button();
            GiderEkle_btn = new Button();
            Gelir_combobox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            Gider_combobox = new ComboBox();
            GelirGiderSil_btn = new Button();
            GelirGiderEkle_IleriButonu = new PictureBox();
            GelirGiderEkle_GeriButonu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GelirGiderEkle_IleriButonu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GelirGiderEkle_GeriButonu).BeginInit();
            SuspendLayout();
            // 
            // Kaynak_lbl
            // 
            Kaynak_lbl.AutoSize = true;
            Kaynak_lbl.Location = new Point(254, 79);
            Kaynak_lbl.Name = "Kaynak_lbl";
            Kaynak_lbl.Size = new Size(59, 20);
            Kaynak_lbl.TabIndex = 0;
            Kaynak_lbl.Text = "Kaynak:";
            // 
            // Miktar_lbl
            // 
            Miktar_lbl.AutoSize = true;
            Miktar_lbl.Location = new Point(259, 135);
            Miktar_lbl.Name = "Miktar_lbl";
            Miktar_lbl.Size = new Size(54, 20);
            Miktar_lbl.TabIndex = 1;
            Miktar_lbl.Text = "Miktar:";
            // 
            // Tarih_lbl
            // 
            Tarih_lbl.AutoSize = true;
            Tarih_lbl.Location = new Point(270, 184);
            Tarih_lbl.Name = "Tarih_lbl";
            Tarih_lbl.Size = new Size(43, 20);
            Tarih_lbl.TabIndex = 2;
            Tarih_lbl.Text = "Tarih:";
            // 
            // Kaynak_txtbox
            // 
            Kaynak_txtbox.Location = new Point(319, 76);
            Kaynak_txtbox.Multiline = true;
            Kaynak_txtbox.Name = "Kaynak_txtbox";
            Kaynak_txtbox.Size = new Size(125, 34);
            Kaynak_txtbox.TabIndex = 3;
            // 
            // Miktar_txtbox
            // 
            Miktar_txtbox.Location = new Point(319, 132);
            Miktar_txtbox.Multiline = true;
            Miktar_txtbox.Name = "Miktar_txtbox";
            Miktar_txtbox.Size = new Size(125, 34);
            Miktar_txtbox.TabIndex = 4;
            // 
            // TarihSecici
            // 
            TarihSecici.Format = DateTimePickerFormat.Short;
            TarihSecici.Location = new Point(319, 184);
            TarihSecici.Name = "TarihSecici";
            TarihSecici.Size = new Size(125, 27);
            TarihSecici.TabIndex = 5;
            // 
            // GelirEkle_btn
            // 
            GelirEkle_btn.BackColor = Color.MediumSeaGreen;
            GelirEkle_btn.Location = new Point(191, 265);
            GelirEkle_btn.Name = "GelirEkle_btn";
            GelirEkle_btn.Size = new Size(180, 60);
            GelirEkle_btn.TabIndex = 6;
            GelirEkle_btn.Text = "Gelir Ekle";
            GelirEkle_btn.UseVisualStyleBackColor = false;
            GelirEkle_btn.Click += GelirEkle_btn_Click;
            // 
            // GiderEkle_btn
            // 
            GiderEkle_btn.BackColor = Color.FromArgb(255, 128, 128);
            GiderEkle_btn.Location = new Point(418, 265);
            GiderEkle_btn.Name = "GiderEkle_btn";
            GiderEkle_btn.Size = new Size(180, 60);
            GiderEkle_btn.TabIndex = 7;
            GiderEkle_btn.Text = "Gider Ekle";
            GiderEkle_btn.UseVisualStyleBackColor = false;
            GiderEkle_btn.Click += GiderEkle_btn_Click;
            // 
            // Gelir_combobox
            // 
            Gelir_combobox.FormattingEnabled = true;
            Gelir_combobox.Location = new Point(191, 378);
            Gelir_combobox.Name = "Gelir_combobox";
            Gelir_combobox.Size = new Size(151, 28);
            Gelir_combobox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 381);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Gelir Seç";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 381);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Gider Seç";
            // 
            // Gider_combobox
            // 
            Gider_combobox.FormattingEnabled = true;
            Gider_combobox.Location = new Point(447, 378);
            Gider_combobox.Name = "Gider_combobox";
            Gider_combobox.Size = new Size(151, 28);
            Gider_combobox.TabIndex = 11;
            // 
            // GelirGiderSil_btn
            // 
            GelirGiderSil_btn.Location = new Point(291, 435);
            GelirGiderSil_btn.Name = "GelirGiderSil_btn";
            GelirGiderSil_btn.Size = new Size(188, 74);
            GelirGiderSil_btn.TabIndex = 12;
            GelirGiderSil_btn.Text = "Gelir/Gider Sil";
            GelirGiderSil_btn.UseVisualStyleBackColor = true;
            GelirGiderSil_btn.Click += GelirGiderSil_btn_Click;
            // 
            // GelirGiderEkle_IleriButonu
            // 
            GelirGiderEkle_IleriButonu.BackColor = Color.Transparent;
            GelirGiderEkle_IleriButonu.Image = (Image)resources.GetObject("GelirGiderEkle_IleriButonu.Image");
            GelirGiderEkle_IleriButonu.Location = new Point(706, 26);
            GelirGiderEkle_IleriButonu.Name = "GelirGiderEkle_IleriButonu";
            GelirGiderEkle_IleriButonu.Size = new Size(64, 64);
            GelirGiderEkle_IleriButonu.SizeMode = PictureBoxSizeMode.AutoSize;
            GelirGiderEkle_IleriButonu.TabIndex = 14;
            GelirGiderEkle_IleriButonu.TabStop = false;
            GelirGiderEkle_IleriButonu.Click += GelirGiderEkle_IleriButonu_Click;
            GelirGiderEkle_IleriButonu.MouseEnter += GelirGiderEkle_IleriButonu_MouseEnter;
            GelirGiderEkle_IleriButonu.MouseLeave += GelirGiderEkle_IleriButonu_MouseLeave;
            // 
            // GelirGiderEkle_GeriButonu
            // 
            GelirGiderEkle_GeriButonu.BackColor = Color.Transparent;
            GelirGiderEkle_GeriButonu.Image = (Image)resources.GetObject("GelirGiderEkle_GeriButonu.Image");
            GelirGiderEkle_GeriButonu.Location = new Point(12, 26);
            GelirGiderEkle_GeriButonu.Name = "GelirGiderEkle_GeriButonu";
            GelirGiderEkle_GeriButonu.Size = new Size(64, 64);
            GelirGiderEkle_GeriButonu.TabIndex = 15;
            GelirGiderEkle_GeriButonu.TabStop = false;
            GelirGiderEkle_GeriButonu.Click += GelirGiderEkle_GeriButonu_Click;
            GelirGiderEkle_GeriButonu.MouseEnter += GelirGiderEkle_GeriButonu_MouseEnter;
            GelirGiderEkle_GeriButonu.MouseLeave += GelirGiderEkle_GeriButonu_MouseLeave;
            // 
            // GelirGiderEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(GelirGiderEkle_GeriButonu);
            Controls.Add(GelirGiderEkle_IleriButonu);
            Controls.Add(GelirGiderSil_btn);
            Controls.Add(Gider_combobox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Gelir_combobox);
            Controls.Add(GiderEkle_btn);
            Controls.Add(GelirEkle_btn);
            Controls.Add(TarihSecici);
            Controls.Add(Miktar_txtbox);
            Controls.Add(Kaynak_txtbox);
            Controls.Add(Tarih_lbl);
            Controls.Add(Miktar_lbl);
            Controls.Add(Kaynak_lbl);
            Name = "GelirGiderEkle";
            Text = "Gelir Gider Uygulaması";
            ((System.ComponentModel.ISupportInitialize)GelirGiderEkle_IleriButonu).EndInit();
            ((System.ComponentModel.ISupportInitialize)GelirGiderEkle_GeriButonu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Kaynak_lbl;
        private Label Miktar_lbl;
        private Label Tarih_lbl;
        private TextBox Kaynak_txtbox;
        private TextBox Miktar_txtbox;
        private DateTimePicker TarihSecici;
        private Button GelirEkle_btn;
        private Button GiderEkle_btn;
        private ComboBox Gelir_combobox;
        private Label label4;
        private Label label5;
        private ComboBox Gider_combobox;
        private Button GelirGiderSil_btn;
        private PictureBox GelirGiderEkle_IleriButonu;
        private PictureBox GelirGiderEkle_GeriButonu;
    }
}