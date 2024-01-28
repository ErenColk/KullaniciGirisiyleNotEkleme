namespace KullaniciAdiSifreİleNotEkleme
{
    partial class UyeOlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeOlma));
            txtPassword = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            chkSozlesme = new CheckBox();
            btnKayitEkle = new Button();
            label3 = new Label();
            lblZorluk = new Label();
            pbSifreyiGoster = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pbSifreyiGoster).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(8, 165);
            txtPassword.Margin = new Padding(4, 9, 4, 9);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(282, 29);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(8, 91);
            txtKullaniciAdi.Margin = new Padding(4, 9, 4, 9);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(282, 29);
            txtKullaniciAdi.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 10;
            label1.Text = "Kullanıcı Adı:";
            // 
            // chkSozlesme
            // 
            chkSozlesme.AutoSize = true;
            chkSozlesme.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chkSozlesme.Location = new Point(96, 291);
            chkSozlesme.Margin = new Padding(4, 4, 4, 4);
            chkSozlesme.Name = "chkSozlesme";
            chkSozlesme.Size = new Size(194, 21);
            chkSozlesme.TabIndex = 13;
            chkSozlesme.Text = "Kullanıcı Sözleşmesini Okudum";
            chkSozlesme.UseVisualStyleBackColor = true;
            chkSozlesme.CheckedChanged += chkSozlesme_CheckedChanged;
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.Location = new Point(130, 243);
            btnKayitEkle.Margin = new Padding(4, 4, 4, 4);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(160, 40);
            btnKayitEkle.TabIndex = 14;
            btnKayitEkle.Text = "KAYIT OL";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += btnKayitEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 22);
            label3.TabIndex = 15;
            label3.Text = "Şifre Zorluk Seviyesi:";
            // 
            // lblZorluk
            // 
            lblZorluk.BorderStyle = BorderStyle.Fixed3D;
            lblZorluk.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblZorluk.Location = new Point(219, 213);
            lblZorluk.Margin = new Padding(4, 0, 4, 0);
            lblZorluk.Name = "lblZorluk";
            lblZorluk.Size = new Size(71, 21);
            lblZorluk.TabIndex = 15;
            // 
            // pbSifreyiGoster
            // 
            pbSifreyiGoster.Image = (Image)resources.GetObject("pbSifreyiGoster.Image");
            pbSifreyiGoster.Location = new Point(290, 165);
            pbSifreyiGoster.Margin = new Padding(4, 3, 4, 3);
            pbSifreyiGoster.Name = "pbSifreyiGoster";
            pbSifreyiGoster.Size = new Size(26, 29);
            pbSifreyiGoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSifreyiGoster.TabIndex = 16;
            pbSifreyiGoster.TabStop = false;
            pbSifreyiGoster.MouseEnter += pbSifreyiGoster_MouseEnter;
            pbSifreyiGoster.MouseLeave += pbSifreyiGoster_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbSifreyiGoster);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(lblZorluk);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnKayitEkle);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(chkSozlesme);
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 364);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜYELİK";
            // 
            // UyeOlma
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 388);
            Controls.Add(groupBox1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UyeOlma";
            Text = "UyeOlma";
            Load += UyeOlma_Load;
            ((System.ComponentModel.ISupportInitialize)pbSifreyiGoster).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private CheckBox chkSozlesme;
        private Button btnKayitEkle;
        private Label label3;
        private Label lblZorluk;
        private PictureBox pbSifreyiGoster;
        private GroupBox groupBox1;
    }
}