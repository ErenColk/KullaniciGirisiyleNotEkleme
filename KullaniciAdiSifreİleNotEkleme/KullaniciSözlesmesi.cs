﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace KullaniciAdiSifreİleNotEkleme
{
    public partial class KullaniciSözlesmesi : Form
    {
        UyeOlma _uyeForm;

        public KullaniciSözlesmesi(UyeOlma uyeForm)
        {
            _uyeForm = uyeForm;
            InitializeComponent();

        }

   
        private void KullaniciSözlesmesi_Load(object sender, EventArgs e)
        {

            string sozlesme = Path.Combine(Application.StartupPath, "Sozlesme.txt");

            File.AppendAllText(sozlesme, "");
         

            StreamWriter swSozlesme = new StreamWriter(sozlesme);
            #region SOZLESME

            swSozlesme.Write("SİTE KULLANIM ŞARTLARI\r\nLütfen sitemizi kullanmadan evvel bu ‘site kullanım şartları’nı dikkatlice okuyunuz. \r\nBu alışveriş sitesini kullanan ve alışveriş yapan müşterilerimiz aşağıdaki şartları kabul etmiş varsayılmaktadır:\r\nSitemizdeki web sayfaları ve ona bağlı tüm sayfalar (‘site’) ……………………… adresindeki ……………………………….firmasının (Firma) malıdır ve onun tarafından işletilir. Sizler (‘Kullanıcı’) sitede sunulan tüm hizmetleri kullanırken aşağıdaki şartlara tabi olduğunuzu, sitedeki hizmetten yararlanmakla ve kullanmaya devam etmekle; Bağlı olduğunuz yasalara göre sözleşme imzalama hakkına, yetkisine ve hukuki ehliyetine sahip ve 18 yaşın üzerinde olduğunuzu, bu sözleşmeyi okuduğunuzu, anladığınızı ve sözleşmede yazan şartlarla bağlı olduğunuzu kabul etmiş sayılırsınız. \r\n\r\nİşbu sözleşme taraflara sözleşme konusu site ile ilgili hak ve yükümlülükler yükler ve taraflar işbu sözleşmeyi kabul ettiklerinde bahsi geçen hak ve yükümlülükleri eksiksiz, doğru, zamanında, işbu sözleşmede talep edilen şartlar dâhilinde yerine getireceklerini beyan ederler.\r\n\r\n1. SORUMLULUKLAR\r\na.Firma, fiyatlar ve sunulan ürün ve hizmetler üzerinde değişiklik yapma hakkını her zaman saklı tutar. \r\nb.Firma, üyenin sözleşme konusu hizmetlerden, teknik arızalar dışında yararlandırılacağını kabul ve taahhüt eder.\r\nc.Kullanıcı, sitenin kullanımında tersine mühendislik yapmayacağını ya da bunların kaynak kodunu bulmak veya elde etmek amacına yönelik herhangi bir başka işlemde bulunmayacağını aksi halde ve 3. Kişiler nezdinde doğacak zararlardan sorumlu olacağını, hakkında hukuki ve cezai işlem yapılacağını peşinen kabul eder. \r\nd.Kullanıcı, site içindeki faaliyetlerinde, sitenin herhangi bir bölümünde veya iletişimlerinde genel ahlaka ve adaba aykırı, kanuna aykırı, 3. Kişilerin haklarını zedeleyen, yanıltıcı, saldırgan, müstehcen, pornografik, kişilik haklarını zedeleyen, telif haklarına aykırı, yasa dışı faaliyetleri teşvik eden içerikler üretmeyeceğini, paylaşmayacağını kabul eder. Aksi halde oluşacak zarardan tamamen kendisi sorumludur ve bu durumda ‘Site’ yetkilileri, bu tür hesapları askıya alabilir, sona erdirebilir, yasal süreç başlatma hakkını saklı tutar. Bu sebeple yargı mercilerinden etkinlik veya kullanıcı hesapları ile ilgili bilgi talepleri gelirse paylaşma hakkını saklı tutar.\r\ne.Sitenin üyelerinin birbirleri veya üçüncü şahıslarla olan ilişkileri kendi sorumluluğundadır. \r\n\r\n2.  Fikri Mülkiyet Hakları\r\n\r\n2.1. İşbu Site’de yer alan ünvan, işletme adı, marka, patent, logo, tasarım, bilgi ve yöntem gibi tescilli veya tescilsiz tüm fikri mülkiyet hakları site işleteni ve sahibi firmaya veya belirtilen ilgilisine ait olup, ulusal ve uluslararası hukukun koruması altındadır. İşbu Site’nin ziyaret edilmesi veya bu Site’deki hizmetlerden yararlanılması söz konusu fikri mülkiyet hakları konusunda hiçbir hak vermez.\r\n2.2. Site’de yer alan bilgiler hiçbir şekilde çoğaltılamaz, yayınlanamaz, kopyalanamaz, sunulamaz ve/veya aktarılamaz. Site’nin bütünü veya bir kısmı diğer bir internet sitesinde izinsiz olarak kullanılamaz. \r\n\r\n3. Gizli Bilgi\r\n3.1. Firma, site üzerinden kullanıcıların ilettiği kişisel bilgileri 3. Kişilere açıklamayacaktır. Bu kişisel bilgiler; kişi adı-soyadı, adresi, telefon numarası, cep telefonu, e-posta adresi gibi Kullanıcı’yı tanımlamaya yönelik her türlü diğer bilgiyi içermekte olup, kısaca ‘Gizli Bilgiler’ olarak anılacaktır.\r\n\r\n3.2. Kullanıcı, sadece tanıtım, reklam, kampanya, promosyon, duyuru vb. pazarlama faaliyetleri kapsamında kullanılması ile sınırlı olmak üzere, Site’nin sahibi olan firmanın kendisine ait iletişim, portföy durumu ve demografik bilgilerini iştirakleri ya da bağlı bulunduğu grup şirketleri ile paylaşmasına muvafakat ettiğini kabul ve beyan eder. Bu kişisel bilgiler firma bünyesinde müşteri profili belirlemek, müşteri profiline uygun promosyon ve kampanyalar sunmak ve istatistiksel çalışmalar yapmak amacıyla kullanılabilecektir.\r\n\r\n3.3. Gizli Bilgiler, ancak resmi makamlarca usulü dairesinde bu bilgilerin talep edilmesi halinde ve yürürlükteki emredici mevzuat hükümleri gereğince resmi makamlara açıklama yapılmasının zorunlu olduğu durumlarda resmi makamlara açıklanabilecektir.\r\n\r\n4. Garanti Vermeme: İŞBU SÖZLEŞME MADDESİ UYGULANABİLİR KANUNUN İZİN VERDİĞİ AZAMİ ÖLÇÜDE GEÇERLİ OLACAKTIR. FİRMA TARAFINDAN SUNULAN HİZMETLER \"OLDUĞU GİBİ” VE \"MÜMKÜN OLDUĞU” TEMELDE SUNULMAKTA VE PAZARLANABİLİRLİK, BELİRLİ BİR AMACA UYGUNLUK VEYA İHLAL ETMEME KONUSUNDA TÜM ZIMNİ GARANTİLER DE DÂHİL OLMAK ÜZERE HİZMETLER VEYA UYGULAMA İLE İLGİLİ OLARAK (BUNLARDA YER ALAN TÜM BİLGİLER DÂHİL) SARİH VEYA ZIMNİ, KANUNİ VEYA BAŞKA BİR NİTELİKTE HİÇBİR GARANTİDE BULUNMAMAKTADIR. \r\n\r\n5. Kayıt ve Güvenlik \r\nKullanıcı, doğru, eksiksiz ve güncel kayıt bilgilerini vermek zorundadır. Aksi halde bu Sözleşme ihlal edilmiş sayılacak ve Kullanıcı bilgilendirilmeksizin hesap kapatılabilecektir.\r\nKullanıcı, site ve üçüncü taraf sitelerdeki şifre ve hesap güvenliğinden kendisi sorumludur. Aksi halde oluşacak veri kayıplarından ve güvenlik ihlallerinden veya donanım ve cihazların zarar görmesinden Firma sorumlu tutulamaz.\r\n\r\n6. Mücbir Sebep\r\n\r\nTarafların kontrolünde olmayan; tabii afetler, yangın, patlamalar, iç savaşlar, savaşlar, ayaklanmalar, halk hareketleri, seferberlik ilanı, grev, lokavt ve salgın hastalıklar, altyapı ve internet arızaları, elektrik kesintisi gibi sebeplerden (aşağıda birlikte \"Mücbir Sebep” olarak anılacaktır.) dolayı sözleşmeden doğan yükümlülükler taraflarca ifa edilemez hale gelirse, taraflar bundan sorumlu değildir. Bu sürede Taraflar’ın işbu Sözleşme’den doğan hak ve yükümlülükleri askıya alınır. \r\n\r\n7. Sözleşmenin Bütünlüğü ve Uygulanabilirlik\r\n\r\nİşbu sözleşme şartlarından biri, kısmen veya tamamen geçersiz hale gelirse, sözleşmenin geri kalanı geçerliliğini korumaya devam eder.\r\n\r\n8. Sözleşmede Yapılacak Değişiklikler\r\n\r\nFirma, dilediği zaman sitede sunulan hizmetleri ve işbu sözleşme şartlarını kısmen veya tamamen değiştirebilir. Değişiklikler sitede yayınlandığı tarihten itibaren geçerli olacaktır. Değişiklikleri takip etmek Kullanıcı’nın sorumluluğundadır. Kullanıcı, sunulan hizmetlerden yararlanmaya devam etmekle bu değişiklikleri de kabul etmiş sayılır.\r\n\r\n9. Tebligat\r\nİşbu Sözleşme ile ilgili taraflara gönderilecek olan tüm bildirimler, Firma’nın bilinen e.posta adresi ve kullanıcının üyelik formunda belirttiği e.posta adresi vasıtasıyla yapılacaktır. Kullanıcı, üye olurken belirttiği adresin geçerli tebligat adresi olduğunu, değişmesi durumunda 5 gün içinde yazılı olarak diğer tarafa bildireceğini, aksi halde bu adrese yapılacak tebligatların geçerli sayılacağını kabul eder.\r\n\r\n10. Delil Sözleşmesi\r\nTaraflar arasında işbu sözleşme ile ilgili işlemler için çıkabilecek her türlü uyuşmazlıklarda Taraflar’ın defter, kayıt ve belgeleri ile ve bilgisayar kayıtları ve faks kayıtları 6100 sayılı Hukuk Muhakemeleri Kanunu uyarınca delil olarak kabul edilecek olup, kullanıcı bu kayıtlara itiraz etmeyeceğini kabul eder.\r\n\r\n11. Uyuşmazlıkların Çözümü\r\nİşbu Sözleşme’nin uygulanmasından veya yorumlanmasından doğacak her türlü uyuşmazlığın çözümünde İstanbul (Merkez) Adliyesi Mahkemeleri ve İcra Daireleri yetkilidir.");



            #endregion

            swSozlesme.Close() ;


            Label lblSozlesme = new Label();
            lblSozlesme.AutoSize = true;

            pnlSozlesmeMetni.Controls.Add(lblSozlesme);

            StreamReader srSozlesme = new StreamReader(sozlesme);

            lblSozlesme.Text = srSozlesme.ReadToEnd();

            btnOkudumAnladim.Enabled = false;
            srSozlesme.Close();

            if (pnlSozlesmeMetni.VerticalScroll.Value == pnlSozlesmeMetni.VerticalScroll.Maximum - pnlSozlesmeMetni.Height)
            {
                // Butonu aktif hale getiriyoruz
                btnOkudumAnladim.Enabled = true;
            }
            else
            {
                // Dikey kaydırma çubuğu en altta değilse butonu devre dışı bırakıyoruz
                btnOkudumAnladim.Enabled = false;
            }


            MessageBox.Show("OKUDUM ANLADIM BUTONUNA TIKLAMANIZ İÇİN SCROLL BARI FAREYLE AŞAĞI İNDİREREK METNİ OKUMANIZ GEREKMEKTE!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }


        private void pnlSozlesmeMetni_Scroll(object sender, ScrollEventArgs e)
        {

 
            if (pnlSozlesmeMetni.VerticalScroll.Value >= 398)
            {
                btnOkudumAnladim.Enabled = true;
            }

        }



        private void btnOkudumAnladim_Click(object sender, EventArgs e)
        {

            

            _uyeForm.acma = false;
            this.Close();


        }
    }
}
