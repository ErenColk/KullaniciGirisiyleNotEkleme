using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiSifreİleNotEkleme
{
    public partial class NotEkle : Form
    {
        Form1 _form1;

        public NotEkle(Form1 anaForm)
        {
            InitializeComponent();
            _form1 = anaForm;
        }

        string notBasliklari;
        string notlar;
        string notBasliklariGelen;
        string notlarGelen;
        string[] notBasliklariDizi = new string[0];
        string[] notlarDizi = new string[0];

        private void NotEkle_Load(object sender, EventArgs e)
        {

            notBasliklari = Path.Combine(Application.StartupPath, $"{_form1.girisYapilanKullaniciAdi}.txt"); // GELEN KULLANICI GİRİŞİNE GÖRE NOT DEFTERİ YOLUNU SEÇİYORUM VE DİZİYE AÇILIŞ EKRANINDA ATIYORUM
            notlar = Path.Combine(Application.StartupPath, $"{_form1.girisYapilanKullaniciAdi}notlar.txt");//GELEN KULLANICI GİRİŞİNE GÖRE NOT DEFTERİ YOLUNU SEÇİYORUM VE DİZİYE AÇILIŞ EKRANINDA ATIYORUM
            File.AppendAllText(notBasliklari, "");
            File.AppendAllText(notlar, "");

            txtNotBasligi.Hide();
            rbMetinKutusu.Hide();



            //BURADA DİZİYE ATMA İŞLEMİNİ YAPIYORUM.
            OkuVeDiziyeAt(notBasliklari, notlar);

            //SPLİT İLE DİZİYE ATTIGIMIZ TAKDİRDE DİZİNİN SON ELEMANINA "" İFADE DAHA ATIYORDU VE DİZİNİN ELEMAN SAYISI LİSTBOXTAKİ TOPLAM İNDEKS SAYISINDAN FAZLA OLUYORDU BUNDAN DOLAYI HER DİZİYE ELEMAN EKLENDİĞİNDE SONDA EĞER "" İFADE VAR İSE DİZİDEN KALDIRDIM.
            if (notBasliklariDizi[notBasliklariDizi.Length - 1] == "" && notlarDizi[notlarDizi.Length - 1] == "")
            {
                Array.Resize(ref notBasliklariDizi, notBasliklariDizi.Length - 1);
                Array.Resize(ref notlarDizi, notlarDizi.Length - 1);
            }

            //EN SON HALİYLE EKRAN AÇILIRKEN LİSTEYE EKLEDİM.
            lbNotListesi.Items.AddRange(notBasliklariDizi);




        }


        //NOT EKLE KISMINA GİRME DİYE BİR BOOL DEGER ATADIM EGER NOT EKLEYE TIKLARSAK LİSTBOXIN SELECTEDİNDEXİNİ -1 E EŞİTLEYECEK VE KAYDET BUTONUNDA YAPACAĞIMIZ İŞLEME GÖRE NOTTA DÜZELTME VEYA YENİ NOT EKLEME İŞLEMİ YAPACAK
        private void btnNotEkle_Click(object sender, EventArgs e)
        {

            girme = true;
            lbNotListesi.SelectedIndex = -1;
            txtNotBasligi.Show();
            rbMetinKutusu.Show();
            txtNotBasligi.Text = "";
            rbMetinKutusu.Text = "";
            txtNotBasligi.Focus();



        }



        bool girme = false;
        private void lbNotListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtNotBasligi.Show();
            rbMetinKutusu.Show();
            if (!girme)
            {
                try
                {

                    txtNotBasligi.Text = notBasliklariDizi[lbNotListesi.SelectedIndex];
                    rbMetinKutusu.Text = notlarDizi[lbNotListesi.SelectedIndex];


                }
                catch (Exception)
                {
                    MessageBox.Show("BAŞLIKLARA TIKLAMANIZ GEREKİYOR!\a ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            girme = false;//BURADA İŞLEM BİTTİKTEN SONRA TEKRAR FALSE ÇEKİYORUMKİ TRUEDA KALIRSA LİSTBOXTA İTEMA TIKLADIGIMIZDA İŞLEM YAPAMAYIZ. NOT EKLEYE TIKLARSA TEKRAR TRUE YA ÇEKECEK.


        }
        string[] kopyaDiziBasliklar = new string[0];
        string[] kopyaDiziNotlar = new string[0];
        string metinBasliklar;
        string metinNotlar;

        private void btnNotSil_Click(object sender, EventArgs e)
        {

            //TIKLAMA YAPMADAN SİLMEK İSTERSE KULLANICIYI UYARACAK.
            if (notBasliklariDizi.Length == 0)
            {
                MessageBox.Show("SİLMEK İÇİN ÖNCE NOT EKLEMELİSİNİZ!\a ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                notBasliklariDizi[lbNotListesi.SelectedIndex] = "";
                notlarDizi[lbNotListesi.SelectedIndex] = "";

            }
            catch (Exception)
            {
                MessageBox.Show("SİLMEK İÇİN ÖNCE LİSTEDEN SEÇİM YAPMALISINIZ\a ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;

            }

            //ÖNCE DİZİDEN SİLİYORUM ELEMANI VE TEKRARDAN DİZİDEKİ ELEMANLARI NOT DEFTERİNE YAZDIRIYORUM.
            Array.Resize(ref kopyaDiziBasliklar, notBasliklariDizi.Length);
            Array.Resize(ref kopyaDiziNotlar, notlarDizi.Length);

            notBasliklariDizi.CopyTo(kopyaDiziBasliklar, 0);
            notlarDizi.CopyTo(kopyaDiziNotlar, 0);

            Array.Resize(ref notBasliklariDizi, 0);
            Array.Resize(ref notlarDizi, 0);
            foreach (string basliklar in kopyaDiziBasliklar)
            {
                if (basliklar != "")
                {
                    Array.Resize(ref notBasliklariDizi, notBasliklariDizi.Length + 1);
                    notBasliklariDizi[notBasliklariDizi.Length - 1] = basliklar;

                }
            }
            foreach (string basliklar in kopyaDiziNotlar)
            {
                if (basliklar != "")
                {
                    Array.Resize(ref notlarDizi, notlarDizi.Length + 1);
                    notlarDizi[notlarDizi.Length - 1] = basliklar;
                }
            }


            StreamWriter swBasliklar = new StreamWriter(notBasliklari);
            StreamWriter swNotlar = new StreamWriter(notlar);
            metinBasliklar = "";
            metinNotlar = "";

            foreach (string item in notBasliklariDizi)
            {
                metinBasliklar += item + "\"\"\"";
            }

            foreach (string item in notlarDizi)
            {
                metinNotlar += item + "\"\"\"";
            }


            swBasliklar.Write(metinBasliklar);
            swNotlar.Write(metinNotlar);


            swBasliklar.Close();
            swNotlar.Close();


            lbNotListesi.Items.Clear();

            lbNotListesi.Items.AddRange(notBasliklariDizi);

            OkuVeDiziyeAt(notBasliklari, notlar);

            txtNotBasligi.Text = "";
            rbMetinKutusu.Text = "";


        }

        int index;
        string metin = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            index = lbNotListesi.SelectedIndex;
            //LİST BOX ÜSTÜNDE BİR HERHANGİ BİR İTEMA TIKLAMADIGIMIZDA  BURAYA GİRER. NOT EKLEYE TIKLANDIGINDA İNDEXE -1 VERDİM VE BURAYA GİREREK YENİ NOT EKLEMESİNİ SAĞLADIM. LİSTBOXTA BİR İTEME TIKLARSA AŞAĞIDAKİ ELSE KOMUTUNA GİDECEK
            if (index == -1)
            {

                if (notBasliklariDizi.Contains(txtNotBasligi.Text))
                {
                    MessageBox.Show("Aynı Başlıktan Yalnızca Bir Kere Ekleyebilirsiniz!\a ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                if (notBasliklariGelen != null && txtNotBasligi.Text.Length > 0 && rbMetinKutusu.Text.Length > 0)
                {
                    StreamWriter swNotBasligi = new StreamWriter(notBasliklari);
                    StreamWriter swNotlar = new StreamWriter(notlar);
                    swNotBasligi.Write(notBasliklariGelen += txtNotBasligi.Text + "\"\"\"");
                    swNotlar.Write(notlarGelen += rbMetinKutusu.Text + "\"\"\"");
                    lbNotListesi.Items.Add(txtNotBasligi.Text);
                    swNotlar.Close();
                    swNotBasligi.Close();

                }
                else
                {
                    if (txtNotBasligi.Text.Length == 0)
                        MessageBox.Show("METİN BAŞLIĞI EKLEMENİZ GEREKİYOR!\a", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else if (rbMetinKutusu.Text.Length == 0)
                        MessageBox.Show("METİN İÇERİĞİ EKLEMENİZ GEREKİYOR!\a", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("METİN BAŞLIĞI VE METİN İÇERİĞİ ALANINI DOLDURMANIZ GEREKİYOR!\a", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    return;
                }


                OkuVeDiziyeAt(notBasliklari, notlar);


                if (notBasliklariDizi[notBasliklariDizi.Length - 1] == "" && notlarDizi[notlarDizi.Length - 1] == "")

                {
                    Array.Resize(ref notBasliklariDizi, notBasliklariDizi.Length - 1);
                    Array.Resize(ref notlarDizi, notlarDizi.Length - 1);
                }


            }
            //NOT EKLEYE TIKLADIĞI ANDA BURAYA DEĞİL ÜSTE GİREREK KAYDET YAPTIGIMIZDA YENI NOTLARA EKLER YALNIZ LİSTBOX ÜSTÜNDE BİR NOTA TIKLAYIP KAYDET DER İSEK ELSE KOMUTUNA GİREREK O NOT ÜSTÜNDE DÜZELTME YAPARAK TEKRAR YAZDIRIR.
            else
            {


                notBasliklariDizi[lbNotListesi.SelectedIndex] = txtNotBasligi.Text;
                notlarDizi[lbNotListesi.SelectedIndex] = rbMetinKutusu.Text;

                lbNotListesi.Items.Clear();
                StreamWriter swNotBasligi = new StreamWriter(notBasliklari);
                foreach (string item in notBasliklariDizi)
                {
                    metin += item + "\"\"\"";

                }
                swNotBasligi.Write(metin);
                metin = "";

                foreach (string item in notlarDizi)
                {

                    metin += item + "\"\"\"";

                }

                StreamWriter swNotlar = new StreamWriter(notlar);
                swNotlar.Write(metin);
                metin = "";
                lbNotListesi.Items.AddRange(notBasliklariDizi);
                swNotlar.Close();
                swNotBasligi.Close();



            }





        }

        private void OkuVeDiziyeAt(string baslik, string not)
        {



            StreamReader srNotBasligi = new StreamReader(baslik);
            StreamReader srNotlar = new StreamReader(not);



            notBasliklariGelen = srNotBasligi.ReadToEnd();
            notlarGelen = srNotlar.ReadToEnd();

            notBasliklariDizi = notBasliklariGelen.Split("\"\"\"");
            notlarDizi = notlarGelen.Split("\"\"\"");

            srNotBasligi.Close();
            srNotlar.Close();


        }

        private void NotEkle_FormClosed(object sender, FormClosedEventArgs e)
        {


            //DialogResult dr =   MessageBox.Show("METİN BAŞLIĞI VE METİN İÇERİĞİ ALANINI DOLDURMANIZ GEREKİYOR!\a", "BİLGİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            Application.Exit();

        }
    }
}
