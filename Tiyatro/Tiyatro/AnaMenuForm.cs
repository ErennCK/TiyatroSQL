using System; // Temel sistem işlevlerini içeren kütüphane.
using System.Collections.Generic; // Koleksiyonlar ve generic yapılar için kütüphane.
using System.ComponentModel; // Bileşenler için kütüphane.
using System.Data; // Veri işlemleri için kullanılan kütüphane.
using System.Drawing; // Grafiksel işlemler için kütüphane.
using System.Linq; // Sorgulama işlemleri için kullanılan kütüphane.
using System.Text; // Metin işleme için kullanılan kütüphane.
using System.Threading.Tasks; // Çoklu görev programlama desteği için kütüphane.
using System.Windows.Forms; // Windows Forms uygulamaları için kütüphane.

namespace Tiyatro // Uygulamanın içinde bulunduğu ad alanı.
{
    public partial class AnaMenuForm : Form // Ana menü formunu tanımlayan sınıf.
    {
        // Kullanıcı bilgileri için özel değişkenler tanımlanıyor.
        private string kullanici_adi; // Kullanıcının adını saklar.
        private string kullanici_soyadi; // Kullanıcının soyadını saklar.
        private string kullanici_mail; // Kullanıcının e-posta adresini saklar.
        private string kullanici_telno; // Kullanıcının telefon numarasını saklar.

        // Ana menü formunun yapıcı metodu.
        public AnaMenuForm(string kullanici_adi, string kullanici_soyadi, string kullanici_mail, string kullanici_telno)
        {
            InitializeComponent(); // Formun bileşenlerini başlatır.
            // Yapıcı metoda gelen parametreler, sınıf değişkenlerine atanıyor.
            this.kullanici_adi = kullanici_adi;
            this.kullanici_soyadi = kullanici_soyadi;
            this.kullanici_mail = kullanici_mail;
            this.kullanici_telno = kullanici_telno;
        }

        // Birinci butona tıklandığında çalışacak olay metodu.
        private void button_1_Click(object sender, EventArgs e)
        {
            Oyunlar frm = new Oyunlar(); // Yeni bir "Oyunlar" formu oluşturuluyor.
            frm.Show(); // "Oyunlar" formu ekranda gösteriliyor.
        }

        // İkinci butona tıklandığında çalışacak olay metodu.
        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgileri ile yeni bir "BiletAl" formu oluşturuluyor.
            BiletAl blt = new BiletAl(kullanici_adi, kullanici_soyadi, kullanici_mail, kullanici_telno);
            blt.Show(); // "BiletAl" formu ekranda gösteriliyor.
        }

        // Üçüncü butona tıklandığında çalışacak olay metodu.
        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgileri ile yeni bir "Biletlerim" formu oluşturuluyor.
            Biletlerim bltlr = new Biletlerim(kullanici_adi, kullanici_soyadi, kullanici_mail, kullanici_telno);
            bltlr.Show(); // "Biletlerim" formu ekranda gösteriliyor.
        }
    }
}
