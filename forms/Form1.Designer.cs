namespace veritabanı_ui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Eposta = new TextBox();
            Sifre = new TextBox();
            Epostabaslık = new Label();
            Sifrebaslık = new Label();
            Giris = new Button();
            Ogretmen = new RadioButton();
            Ogrenci = new RadioButton();
            Anabaslık = new Label();
            admin = new RadioButton();
            SuspendLayout();
            // 
            // Eposta
            // 
            Eposta.BackColor = SystemColors.InactiveCaption;
            Eposta.Cursor = Cursors.IBeam;
            Eposta.Location = new Point(678, 359);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(223, 30);
            Eposta.TabIndex = 0;
            Eposta.TextChanged += eposta_TextChanged;
            // 
            // Sifre
            // 
            Sifre.BackColor = SystemColors.InactiveCaption;
            Sifre.Cursor = Cursors.IBeam;
            Sifre.Location = new Point(678, 428);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(223, 30);
            Sifre.TabIndex = 1;
            Sifre.TextChanged += sifre_TextChanged;
            // 
            // Epostabaslık
            // 
            Epostabaslık.AutoSize = true;
            Epostabaslık.BackColor = SystemColors.ButtonFace;
            Epostabaslık.Location = new Point(554, 359);
            Epostabaslık.Name = "Epostabaslık";
            Epostabaslık.Size = new Size(118, 23);
            Epostabaslık.TabIndex = 2;
            Epostabaslık.Text = "e-posta adresi";
            Epostabaslık.Click += Epostabaslık_Click;
            // 
            // Sifrebaslık
            // 
            Sifrebaslık.AutoSize = true;
            Sifrebaslık.BackColor = SystemColors.ButtonFace;
            Sifrebaslık.Location = new Point(627, 428);
            Sifrebaslık.Name = "Sifrebaslık";
            Sifrebaslık.Size = new Size(45, 23);
            Sifrebaslık.TabIndex = 3;
            Sifrebaslık.Text = "şifre:";
            Sifrebaslık.Click += label2_Click;
            // 
            // Giris
            // 
            Giris.BackColor = Color.DarkSlateGray;
            Giris.FlatAppearance.BorderSize = 0;
            Giris.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            Giris.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Giris.ForeColor = Color.LightCyan;
            Giris.Location = new Point(704, 494);
            Giris.Name = "Giris";
            Giris.Size = new Size(166, 49);
            Giris.TabIndex = 4;
            Giris.Text = "giriş yap";
            Giris.UseMnemonic = false;
            Giris.UseVisualStyleBackColor = false;
            Giris.UseWaitCursor = true;
            Giris.Click += giris_Click;
            // 
            // Ogretmen
            // 
            Ogretmen.AutoSize = true;
            Ogretmen.Location = new Point(945, 359);
            Ogretmen.Name = "Ogretmen";
            Ogretmen.Size = new Size(106, 27);
            Ogretmen.TabIndex = 5;
            Ogretmen.Text = "öğretmen";
            Ogretmen.UseVisualStyleBackColor = true;
            Ogretmen.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Ogrenci
            // 
            Ogrenci.AutoSize = true;
            Ogrenci.Checked = true;
            Ogrenci.Location = new Point(945, 392);
            Ogrenci.Name = "Ogrenci";
            Ogrenci.Size = new Size(88, 27);
            Ogrenci.TabIndex = 6;
            Ogrenci.TabStop = true;
            Ogrenci.Text = "öğrenci";
            Ogrenci.UseVisualStyleBackColor = true;
            Ogrenci.CheckedChanged += Ogrenci_CheckedChanged;
            // 
            // Anabaslık
            // 
            Anabaslık.AutoSize = true;
            Anabaslık.Font = new Font("Segoe UI", 25F);
            Anabaslık.ForeColor = Color.SteelBlue;
            Anabaslık.Location = new Point(479, 186);
            Anabaslık.Name = "Anabaslık";
            Anabaslık.Size = new Size(621, 57);
            Anabaslık.TabIndex = 7;
            Anabaslık.Text = "DERS PROGRAMI TAKİP SİSTEMİ";
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.Location = new Point(945, 426);
            admin.Name = "admin";
            admin.Size = new Size(79, 27);
            admin.TabIndex = 8;
            admin.TabStop = true;
            admin.Text = "admin";
            admin.UseVisualStyleBackColor = true;
            admin.CheckedChanged += admin_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1260, 647);
            Controls.Add(admin);
            Controls.Add(Anabaslık);
            Controls.Add(Ogrenci);
            Controls.Add(Ogretmen);
            Controls.Add(Giris);
            Controls.Add(Sifrebaslık);
            Controls.Add(Epostabaslık);
            Controls.Add(Sifre);
            Controls.Add(Eposta);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.RoyalBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Eposta;
        private TextBox Sifre;
        private Label Epostabaslık;
        private Label Sifrebaslık;
        private Button Giris;
        private RadioButton Ogretmen;
        private RadioButton Ogrenci;
        private Label Anabaslık;
        private RadioButton admin;
    }
}
