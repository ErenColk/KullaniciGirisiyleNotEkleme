namespace KullaniciAdiSifreİleNotEkleme
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
            llbUyeOl = new LinkLabel();
            txtPassword = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGirisYap = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            chkBeniHatirla = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // llbUyeOl
            // 
            llbUyeOl.AutoSize = true;
            llbUyeOl.Location = new Point(219, 273);
            llbUyeOl.Margin = new Padding(4, 0, 4, 0);
            llbUyeOl.Name = "llbUyeOl";
            llbUyeOl.Size = new Size(206, 22);
            llbUyeOl.TabIndex = 9;
            llbUyeOl.TabStop = true;
            llbUyeOl.Text = "Üye Olmak İçin Tıklayınız";
            llbUyeOl.LinkClicked += llbUyeOl_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(36, 173);
            txtPassword.Margin = new Padding(4, 7, 4, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(388, 29);
            txtPassword.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(36, 100);
            txtKullaniciAdi.Margin = new Padding(4, 7, 4, 7);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(388, 29);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı:";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(36, 215);
            btnGirisYap.Margin = new Padding(4, 7, 4, 7);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(389, 48);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 173);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkBeniHatirla);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnGirisYap);
            groupBox1.Controls.Add(llbUyeOl);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 374);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Girişi";
            // 
            // chkBeniHatirla
            // 
            chkBeniHatirla.AutoSize = true;
            chkBeniHatirla.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chkBeniHatirla.Location = new Point(36, 273);
            chkBeniHatirla.Name = "chkBeniHatirla";
            chkBeniHatirla.Size = new Size(119, 26);
            chkBeniHatirla.TabIndex = 11;
            chkBeniHatirla.Text = "Beni Hatırla";
            chkBeniHatirla.UseVisualStyleBackColor = true;
            chkBeniHatirla.CheckedChanged += chkBeniHatirla_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 398);
            Controls.Add(groupBox1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel llbUyeOl;
        private TextBox txtPassword;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button btnGirisYap;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private CheckBox chkBeniHatirla;
    }
}