namespace FinansUygulamasiProjesi
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernametxtbox = new TextBox();
            passwtextbox = new TextBox();
            GirisButonu = new Button();
            KayitButonu = new Button();
            usernamelbl = new Label();
            passwlbl = new Label();
            girislbl = new Label();
            SuspendLayout();
            // 
            // usernametxtbox
            // 
            usernametxtbox.Location = new Point(344, 184);
            usernametxtbox.Multiline = true;
            usernametxtbox.Name = "usernametxtbox";
            usernametxtbox.Size = new Size(150, 30);
            usernametxtbox.TabIndex = 0;
            // 
            // passwtextbox
            // 
            passwtextbox.Location = new Point(344, 248);
            passwtextbox.Multiline = true;
            passwtextbox.Name = "passwtextbox";
            passwtextbox.PasswordChar = '*';
            passwtextbox.Size = new Size(150, 30);
            passwtextbox.TabIndex = 1;
            // 
            // GirisButonu
            // 
            GirisButonu.Location = new Point(177, 353);
            GirisButonu.Name = "GirisButonu";
            GirisButonu.Size = new Size(180, 60);
            GirisButonu.TabIndex = 2;
            GirisButonu.Text = "Giriş Yap";
            GirisButonu.UseVisualStyleBackColor = true;
            GirisButonu.Click += GirisButonu_Click;
            // 
            // KayitButonu
            // 
            KayitButonu.Location = new Point(437, 353);
            KayitButonu.Name = "KayitButonu";
            KayitButonu.Size = new Size(180, 60);
            KayitButonu.TabIndex = 3;
            KayitButonu.Text = "Kayıt Ol";
            KayitButonu.UseVisualStyleBackColor = true;
            KayitButonu.Click += KayitButonu_Click;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            usernamelbl.Location = new Point(214, 184);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(124, 28);
            usernamelbl.TabIndex = 4;
            usernamelbl.Text = "Kullanıcı Adı:";
            // 
            // passwlbl
            // 
            passwlbl.AutoSize = true;
            passwlbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwlbl.Location = new Point(283, 248);
            passwlbl.Name = "passwlbl";
            passwlbl.Size = new Size(55, 28);
            passwlbl.TabIndex = 5;
            passwlbl.Text = "Şifre:";
            // 
            // girislbl
            // 
            girislbl.AutoSize = true;
            girislbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            girislbl.Location = new Point(63, 72);
            girislbl.Name = "girislbl";
            girislbl.Size = new Size(687, 38);
            girislbl.TabIndex = 6;
            girislbl.Text = "GELİR GİDER HESAPLAMA SİSTEMİMİZE HOŞGELDİNİZ";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(girislbl);
            Controls.Add(passwlbl);
            Controls.Add(usernamelbl);
            Controls.Add(KayitButonu);
            Controls.Add(GirisButonu);
            Controls.Add(passwtextbox);
            Controls.Add(usernametxtbox);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir Gider Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametxtbox;
        private TextBox passwtextbox;
        private Button GirisButonu;
        private Button KayitButonu;
        private Label usernamelbl;
        private Label passwlbl;
        private Label girislbl;
    }
}
