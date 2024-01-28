namespace KullaniciAdiSifreİleNotEkleme
{
    partial class KullaniciSözlesmesi
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
            pnlSozlesmeMetni = new Panel();
            btnOkudumAnladim = new Button();
            SuspendLayout();
            // 
            // pnlSozlesmeMetni
            // 
            pnlSozlesmeMetni.AutoScroll = true;
            pnlSozlesmeMetni.BorderStyle = BorderStyle.FixedSingle;
            pnlSozlesmeMetni.Location = new Point(12, 12);
            pnlSozlesmeMetni.Name = "pnlSozlesmeMetni";
            pnlSozlesmeMetni.Size = new Size(586, 399);
            pnlSozlesmeMetni.TabIndex = 0;
            pnlSozlesmeMetni.Scroll += pnlSozlesmeMetni_Scroll;
            // 
            // btnOkudumAnladim
            // 
            btnOkudumAnladim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOkudumAnladim.Location = new Point(386, 418);
            btnOkudumAnladim.Name = "btnOkudumAnladim";
            btnOkudumAnladim.Size = new Size(212, 23);
            btnOkudumAnladim.TabIndex = 1;
            btnOkudumAnladim.Text = "OKUDUM ANLADIM";
            btnOkudumAnladim.UseVisualStyleBackColor = true;
            btnOkudumAnladim.Click += btnOkudumAnladim_Click;
            // 
            // KullaniciSözlesmesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 453);
            Controls.Add(btnOkudumAnladim);
            Controls.Add(pnlSozlesmeMetni);
            Name = "KullaniciSözlesmesi";
            Text = "KullaniciSözlesmesi";
            Load += KullaniciSözlesmesi_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSozlesmeMetni;
        private Button btnOkudumAnladim;
    }
}