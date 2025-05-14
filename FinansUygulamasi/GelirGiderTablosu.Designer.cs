namespace FinansUygulamasiProjesi
{
    partial class GelirGiderTablosu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirGiderTablosu));
            label1 = new Label();
            toplamgelir_lbl = new Label();
            toplamgider_lbl = new Label();
            aysonudurum_lbl = new Label();
            GelirGiderTablosu_datagridview = new DataGridView();
            GelirGiderTablosu_GeriButonu = new PictureBox();
            Yazdir_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)GelirGiderTablosu_datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GelirGiderTablosu_GeriButonu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 0;
            label1.Text = "Gelir Gider Tablosu";
            // 
            // toplamgelir_lbl
            // 
            toplamgelir_lbl.AutoSize = true;
            toplamgelir_lbl.Location = new Point(69, 363);
            toplamgelir_lbl.Name = "toplamgelir_lbl";
            toplamgelir_lbl.Size = new Size(97, 20);
            toplamgelir_lbl.TabIndex = 1;
            toplamgelir_lbl.Text = "Toplam Gelir:";
            // 
            // toplamgider_lbl
            // 
            toplamgider_lbl.AutoSize = true;
            toplamgider_lbl.Location = new Point(69, 401);
            toplamgider_lbl.Name = "toplamgider_lbl";
            toplamgider_lbl.Size = new Size(102, 20);
            toplamgider_lbl.TabIndex = 2;
            toplamgider_lbl.Text = "Toplam Gider:";
            // 
            // aysonudurum_lbl
            // 
            aysonudurum_lbl.AutoSize = true;
            aysonudurum_lbl.Location = new Point(304, 363);
            aysonudurum_lbl.Name = "aysonudurum_lbl";
            aysonudurum_lbl.Size = new Size(115, 20);
            aysonudurum_lbl.TabIndex = 3;
            aysonudurum_lbl.Text = "Ay Sonu Durum:";
            // 
            // GelirGiderTablosu_datagridview
            // 
            GelirGiderTablosu_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GelirGiderTablosu_datagridview.Location = new Point(236, 57);
            GelirGiderTablosu_datagridview.Name = "GelirGiderTablosu_datagridview";
            GelirGiderTablosu_datagridview.RowHeadersWidth = 51;
            GelirGiderTablosu_datagridview.Size = new Size(300, 188);
            GelirGiderTablosu_datagridview.TabIndex = 4;
            // 
            // GelirGiderTablosu_GeriButonu
            // 
            GelirGiderTablosu_GeriButonu.BackColor = Color.Transparent;
            GelirGiderTablosu_GeriButonu.Image = (Image)resources.GetObject("GelirGiderTablosu_GeriButonu.Image");
            GelirGiderTablosu_GeriButonu.Location = new Point(12, 26);
            GelirGiderTablosu_GeriButonu.Name = "GelirGiderTablosu_GeriButonu";
            GelirGiderTablosu_GeriButonu.Size = new Size(64, 64);
            GelirGiderTablosu_GeriButonu.TabIndex = 16;
            GelirGiderTablosu_GeriButonu.TabStop = false;
            GelirGiderTablosu_GeriButonu.Click += GelirGiderTablosu_GeriButonu_Click;
            GelirGiderTablosu_GeriButonu.MouseEnter += GelirGiderTablosu_GeriButonu_MouseEnter;
            GelirGiderTablosu_GeriButonu.MouseLeave += GelirGiderTablosu_GeriButonu_MouseLeave;
            // 
            // GelirGiderYazdir_btn
            // 
            Yazdir_btn.Location = new Point(277, 267);
            Yazdir_btn.Name = "GelirGiderYazdir_btn";
            Yazdir_btn.Size = new Size(207, 66);
            Yazdir_btn.TabIndex = 17;
            Yazdir_btn.Text = "Gelir/Gider Yazdır";
            Yazdir_btn.UseVisualStyleBackColor = true;
            Yazdir_btn.Click += this.GelirGiderYazdir_btn_Click;
            // 
            // GelirGiderTablosu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Yazdir_btn);
            Controls.Add(GelirGiderTablosu_GeriButonu);
            Controls.Add(GelirGiderTablosu_datagridview);
            Controls.Add(aysonudurum_lbl);
            Controls.Add(toplamgider_lbl);
            Controls.Add(toplamgelir_lbl);
            Controls.Add(label1);
            Name = "GelirGiderTablosu";
            Text = "Gelir Gider Uygulaması";
            ((System.ComponentModel.ISupportInitialize)GelirGiderTablosu_datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)GelirGiderTablosu_GeriButonu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label toplamgelir_lbl;
        private Label toplamgider_lbl;
        private Label aysonudurum_lbl;
        private DataGridView GelirGiderTablosu_datagridview;
        private PictureBox GelirGiderTablosu_GeriButonu;
        private Button Yazdir_btn;
    }
}