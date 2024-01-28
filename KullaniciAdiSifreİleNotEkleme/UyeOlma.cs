using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiSifreİleNotEkleme
{
    public partial class UyeOlma : Form
    {
        public UyeOlma()
        {
            InitializeComponent();
        }


        string kullaniciAdi = Path.Combine(Application.StartupPath, "KullaniciAdi.txt");// İÇERİSİNE KULLANICI ADI VE ŞİFRESİNİ İÇERİSİNDE SAKLAYACAĞIM TXT DOSYA YOLLARINI BELİRTTİM.
        string password = Path.Combine(Application.StartupPath, "Password.txt");    // İÇERİSİNE KULLANICI ADI VE ŞİFRESİNİ İÇERİSİNDE SAKLAYACAĞIM  TXT DOSYA YOLLARINI BELİRTTİM.
        string[] kullaniciAdiDizi = new string[0];   // TXT DOSYASININ İÇİNDE OLAN METNİ SIRASIYLA BİR DİZİYE ATTIM.
        string[] passwordDizi = new string[0];       // TXT DOSYASININ İÇİNDE OLAN METNİ SIRASIYLA BİR DİZİYE ATTIM.  
        string gelenKullaniciAdi;  // BU DEĞİŞKENLERİ TXT DOSYASININ İÇİNDEKİ METNİ OKUYUP İÇERİSİNE ATMAK İÇİN KULLANDIM.
        string gelenPassword;      // BU DEĞİŞKENLERİ TXT DOSYASININ İÇİNDEKİ METNİ OKUYUP İÇERİSİNE ATMAK İÇİN KULLANDIM.
        private void btnKayitEkle_Click(object sender, EventArgs e)
        {




            OkuVeDiziyeAt(kullaniciAdi, password); // TXT DOSYASININ İÇİNDEKİ METNİ OKUYARAK BİR DİZİYE ATMAYI SAĞLADIM.


            bool karakter = false;
            // KULLANICI ADINA SADECE SAYI GİRMESİ DURUMUNDA BÖYLE BİR DÖNGÜ OLUSTURDUM VE KULLANICIYI UYARDIM.
            foreach (char item in txtKullaniciAdi.Text)
            {

                if (char.IsLetter(item))
                    karakter = true;

            }
            if (!karakter)
            {
                MessageBox.Show("Kullanıcı Adınız Karakter İçermelidir!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            //KULLANICI KARAKTER GİRİP EĞER 4 KARAKTERDEN AZ GİRERSE UYARMASI İÇİN BÖYLE BİR KOMUT YAZDIM
            if (txtKullaniciAdi.Text.Length >= 4)
            {
                //KULLANICI ADINI DOGRU GİRMESİ DURUMUNDA BU SEFER ŞİFREYİ KONTROL ETİMEK İÇİN HEM ZOR OLACAK HEM 8 KARAKTERDEN FAZLA OLACAK HEMDE ŞİFRE ALANI TAMAMEN BOŞ OLMAYACAK ŞEKİLDE KULLANICIYI YÖNLENDİRDİM. 
                if (zorlukSeviyesi == "ORTA" || zorlukSeviyesi == "KOLAY")
                {

                    MessageBox.Show("Şifre Zorluk Seviyesi Zor Olmalıdır!\nBunun İçin Ozel Karakter,Rakam ve Karakter Kullanmalısınız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (txtPassword.Text.Length == 0)
                {
                    MessageBox.Show("ŞİFRE ALANINI BOŞ BIRAKTINIZ LÜTFEN DOLDURUNUZ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (txtPassword.Text.Length <= 8)
                {

                    MessageBox.Show("Şifre en az 8 karakter olmalıdır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {

                    //EĞER KULLANICI ADI VE ŞİFRE DOGRU ŞEKİLDE GİRERSE İF BLOGUNA GİRMESİNİ EGER DAHA ÖNCE ÖYLE BİR KULLANICI ADI VARSA ELSE BLOGUNA GİRMESİNİ SAĞLADIM
                    if (!kullaniciAdiDizi.Contains(txtKullaniciAdi.Text))
                    {
                        OkuVeYazdir(kullaniciAdi, password);
                    }
                    else
                    {
                        MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmıştır.");
                        return;
                    }

                }

            }
            else
            {

                MessageBox.Show("KULLANICI ADI 3 KARAKTERDEN FAZLA OLMALI!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            //KAYIT BAŞARILI OLURSA RETURN KEYWORDUNE GİRMEYEREK BURAYA ULAŞACAK VE KULLANICIYI BAŞARILI GİRİŞİ KONUSUNDA UYARACAK.
            MessageBox.Show("Kaydınız Oluşturuldu!");
            this.Close();


        }

        //OKUYUP DİZİYE ATAN VE TXT DOSYASINA YAZI YAZDIRAN METOTLARI BURADA BELİRTTİM
        #region METOTLAR 


        private void OkuVeYazdir(string kullanici, string sifre)
        {





            if (gelenKullaniciAdi == "" || gelenPassword == "")
            {


                StreamWriter usersw = new StreamWriter(kullanici);
                StreamWriter passw = new StreamWriter(sifre);

                usersw.Write(gelenKullaniciAdi += txtKullaniciAdi.Text);
                passw.Write(gelenPassword += txtPassword.Text);
                usersw.Close();
                passw.Close();

            }
            else
            {

                StreamWriter usersw = new StreamWriter(kullanici);
                StreamWriter passw = new StreamWriter(sifre);
                usersw.Write(gelenKullaniciAdi += "\n" + txtKullaniciAdi.Text);
                passw.Write(gelenPassword += "\n" + txtPassword.Text);
                usersw.Close();
                passw.Close();
            }

        }

        private void OkuVeDiziyeAt(string kullanici, string sifre)
        {

            StreamReader user = new StreamReader(kullanici);
            StreamReader pass = new StreamReader(sifre);

            gelenKullaniciAdi = user.ReadToEnd();
            gelenPassword = pass.ReadToEnd();

            kullaniciAdiDizi = gelenKullaniciAdi.Split("\n");
            passwordDizi = gelenPassword.Split("\n");

            user.Close();
            pass.Close();



        }


        #endregion



        //PASSOWRDUN ZORLUGUNU GÖSTERECEK KOMUTU BURADA KULLANDIM.
        string zorlukSeviyesi;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            string gelenDeger = txtPassword.Text;
            zorlukSeviyesi = "";
            bool karater = false;
            bool sayi = false;
            bool ozelKarakter = false;

            foreach (char item in gelenDeger)
            {
                if (char.IsLetter(item))
                {
                    karater = true;
                    zorlukSeviyesi = "KOLAY";
                    lblZorluk.ForeColor = Color.Green;
                    if (sayi == true && ozelKarakter == false)
                    {
                        zorlukSeviyesi = "ORTA";
                        lblZorluk.ForeColor = Color.Blue;
                    }
                    else if (sayi == false && ozelKarakter == true)
                    {
                        zorlukSeviyesi = "ORTA";
                        lblZorluk.ForeColor = Color.Blue;
                    }
                    else if (sayi == true && ozelKarakter == true)

                    {
                        lblZorluk.ForeColor = Color.Red;
                        zorlukSeviyesi = "ZOR";
                    }
                }
                else if (char.IsDigit(item))
                {
                    sayi = true;
                    zorlukSeviyesi = "KOLAY";
                    lblZorluk.ForeColor = Color.Green;
                    if (karater == true && ozelKarakter == false)
                    {
                        zorlukSeviyesi = "ORTA";
                        lblZorluk.ForeColor = Color.Blue;
                    }
                    else if (karater == false && ozelKarakter == true)
                    {
                        zorlukSeviyesi = "ORTA";
                        lblZorluk.ForeColor = Color.Blue;
                    }
                    else if (karater == true && ozelKarakter == true)
                    {
                        zorlukSeviyesi = "ZOR";
                        lblZorluk.ForeColor = Color.Red;
                    }
                }
                else
                {

                    ozelKarakter = true;
                    zorlukSeviyesi = "KOLAY";
                    lblZorluk.ForeColor = Color.Green;
                    if (karater == true && sayi == false)
                    {
                        zorlukSeviyesi = "ORTA";
                        lblZorluk.ForeColor = Color.Blue;
                    }
                    else if (karater == false && sayi == true)
                    {
                        zorlukSeviyesi = "ORTA";
                        lblZorluk.ForeColor = Color.Blue;
                    }
                    else if (karater == true && ozelKarakter == true)
                    {
                        zorlukSeviyesi = "ZOR";
                        lblZorluk.ForeColor = Color.Red;

                    }
                }
            }
            lblZorluk.Text = zorlukSeviyesi;

        }


        //EKRAN AÇILDIGINDA KAYIT EKLE BUTONUNU FALSE YAPTIM.
        private void UyeOlma_Load(object sender, EventArgs e)
        {
            btnKayitEkle.Enabled = false;

        }


        //KULLANICI SÖZLEŞMESİNE TIKLADIGI TAKDİRDE KARŞISINA BİR SÖZLEŞME GELECEK VE SCROOL BARI AŞAĞI İNDİRMEDİĞİ SÜRECE ONAYLAYAMAYACAK. BU ŞEKİLDE OKUMASINI SAĞLADIM.
        public bool acma = true;
        private void chkSozlesme_CheckedChanged(object sender, EventArgs e)
        {


            KullaniciSözlesmesi sozlesme = new KullaniciSözlesmesi(this);
            if (acma)
            {
                sozlesme.ShowDialog();
            }


            btnKayitEkle.Enabled = true;
            if (!chkSozlesme.Checked)
                btnKayitEkle.Enabled = false;


        }


        // AŞAĞIDAKİ İKİ METOTLA İSE ŞİFREYİ GÖSTERİP ŞİFREYİ SAKLAMASINI SAĞLADIM.
        private void pbSifreyiGoster_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbSifreyiGoster_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
