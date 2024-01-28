namespace KullaniciAdiSifreİleNotEkleme
{
    partial class NotEkle
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
            lbNotListesi = new ListBox();
            btnNotEkle = new Button();
            btnNotSil = new Button();
            btnKaydet = new Button();
            txtNotBasligi = new TextBox();
            rbMetinKutusu = new RichTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lbNotListesi
            // 
            lbNotListesi.FormattingEnabled = true;
            lbNotListesi.ItemHeight = 22;
            lbNotListesi.Location = new Point(11, 30);
            lbNotListesi.Margin = new Padding(5);
            lbNotListesi.Name = "lbNotListesi";
            lbNotListesi.Size = new Size(373, 686);
            lbNotListesi.TabIndex = 0;
            lbNotListesi.SelectedIndexChanged += lbNotListesi_SelectedIndexChanged;
            // 
            // btnNotEkle
            // 
            btnNotEkle.Location = new Point(404, 34);
            btnNotEkle.Margin = new Padding(4, 3, 4, 3);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(189, 34);
            btnNotEkle.TabIndex = 1;
            btnNotEkle.Text = "NOT EKLE";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // btnNotSil
            // 
            btnNotSil.Location = new Point(630, 33);
            btnNotSil.Margin = new Padding(4, 3, 4, 3);
            btnNotSil.Name = "btnNotSil";
            btnNotSil.Size = new Size(189, 35);
            btnNotSil.TabIndex = 1;
            btnNotSil.Text = "NOT SİL";
            btnNotSil.UseVisualStyleBackColor = true;
            btnNotSil.Click += btnNotSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(1140, 711);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(108, 36);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtNotBasligi
            // 
            txtNotBasligi.Location = new Point(7, 28);
            txtNotBasligi.Margin = new Padding(4, 3, 4, 3);
            txtNotBasligi.Name = "txtNotBasligi";
            txtNotBasligi.Size = new Size(826, 29);
            txtNotBasligi.TabIndex = 3;
            // 
            // rbMetinKutusu
            // 
            rbMetinKutusu.Location = new Point(11, 37);
            rbMetinKutusu.Margin = new Padding(4, 3, 4, 3);
            rbMetinKutusu.Name = "rbMetinKutusu";
            rbMetinKutusu.Size = new Size(826, 529);
            rbMetinKutusu.TabIndex = 4;
            rbMetinKutusu.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNotListesi);
            groupBox1.Location = new Point(6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 743);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "NOT BAŞLIKLARI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbMetinKutusu);
            groupBox2.Location = new Point(404, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(844, 572);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "METİN ALANI";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNotBasligi);
            groupBox3.Location = new Point(404, 68);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(844, 65);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "NOT BAŞLIĞI";
            // 
            // NotEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 759);
            Controls.Add(btnKaydet);
            Controls.Add(btnNotSil);
            Controls.Add(btnNotEkle);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "NotEkle";
            Text = "NotEkle";
            FormClosed += NotEkle_FormClosed;
            Load += NotEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbNotListesi;
        private Button btnNotEkle;
        private Button btnNotSil;
        private Button btnKaydet;
        private TextBox txtNotBasligi;
        private RichTextBox rbMetinKutusu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}