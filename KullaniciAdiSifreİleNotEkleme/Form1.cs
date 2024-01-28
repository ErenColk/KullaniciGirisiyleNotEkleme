namespace KullaniciAdiSifreİleNotEkleme
{
    public partial class Form1 : Form
    {

        //deneme
        public Form1()
        {
            InitializeComponent();
        }


        string kullaniciAdi = Path.Combine(Application.StartupPath, "KullaniciAdi.txt");
        string password = Path.Combine(Application.StartupPath, "password.txt");
        string beniHatirla = Path.Combine(Application.StartupPath, "BeniHatirla.txt");
    
  

        private void Form1_Load(object sender, EventArgs e)
        {


            File.AppendAllText(kullaniciAdi, "");
            File.AppendAllText(password, "");
            File.AppendAllText(beniHatirla, "");        


            StreamReader sr = new StreamReader(kullaniciAdi);
            StreamReader r = new StreamReader(password);

            hatirlaAdi = sr.ReadToEnd();
            hatirlaSifre = r.ReadToEnd();

            kullaniciAdiDizi = hatirlaAdi.Split('\n');
            passwordDizi = hatirlaSifre.Split('\n');


            sr.Close();
            r.Close();


            StreamReader reader = new StreamReader(beniHatirla);

            hatirlaAdi = reader.ReadToEnd();


            if (hatirlaAdi != null && hatirlaAdi != "")
            {
                txtKullaniciAdi.Text = kullaniciAdiDizi[Convert.ToInt32(hatirlaAdi)];
                txtPassword.Text = passwordDizi[Convert.ToInt32(hatirlaAdi)];
                chkBeniHatirla.Checked = true;
            }

            reader.Close();

        }
     


        string gelenKullaniciAdi;
        string gelenPassword;
        string[] kullaniciAdiDizi = new string[0];
        string[] passwordDizi = new string[0];
        int indexKullanici = 0;
        public string girisYapilanKullaniciAdi;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
         

            StreamReader user = new StreamReader(kullaniciAdi);
            StreamReader pass = new StreamReader(password);

            gelenKullaniciAdi = user.ReadToEnd();
            gelenPassword = pass.ReadToEnd();

            kullaniciAdiDizi = gelenKullaniciAdi.Split("\n");
            passwordDizi = gelenPassword.Split("\n");


            NotEkle notekle = new NotEkle(this);

            //KULLANICI ADINI GİRDİKTEN SONRA KULLANICI ADINA EŞ GELEN PASSWORDU GİRMESİ İÇİN BÖYLE BİR KOMUT YAZDIM.
            if (kullaniciAdiDizi.Contains(txtKullaniciAdi.Text) && gelenKullaniciAdi != "" && gelenPassword != "")
            {
                indexKullanici = Array.IndexOf(kullaniciAdiDizi, txtKullaniciAdi.Text);

                if (passwordDizi[indexKullanici] == txtPassword.Text)
                {


                    string fileNameBasliklar = $"C:\\Users\\user\\Documents\\{txtKullaniciAdi.Text}.txt";
                    string fileNameNotlar = $"C:\\Users\\user\\Documents\\{txtKullaniciAdi.Text}notlar.txt";
                    File.AppendAllText(fileNameBasliklar, "");
                    File.AppendAllText(fileNameNotlar, "");
                    girisYapilanKullaniciAdi = txtKullaniciAdi.Text;


                    if (chkBeniHatirla.Checked)
                    {

                        StreamWriter swBeniHatirla = new StreamWriter(beniHatirla);
                        swBeniHatirla.Write(indexKullanici.ToString());
                        swBeniHatirla.Close();
                    }
                    else
                    {
                        StreamWriter swBeniHatirla = new StreamWriter(beniHatirla);

                        swBeniHatirla.Write("");

                        swBeniHatirla.Close();

                    }


                    user.Close();
                    pass.Close();
                    notekle.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("HATALI ŞİFRE!\nŞİFRENİZİ TEKRAR GİRİNİZ!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {

                MessageBox.Show("Böyle bir kullancıı hesabı bulunmamakta\nÜye olmak için aşağıdaki linke tıklayınız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            user.Close();
            pass.Close();


        }


        private void llbUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtPassword.Text = "";
            UyeOlma uye = new UyeOlma();
            uye.ShowDialog();

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        string hatirlaAdi;
        string hatirlaSifre;

        private void chkBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}