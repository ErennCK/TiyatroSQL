using System; // Temel sistem işlevleri için kullanılan kütüphane.
using System.Collections.Generic; // Koleksiyonlar ve generic yapılar için kullanılan kütüphane.
using System.ComponentModel; // Bileşenler için kullanılan kütüphane.
using System.Data; // Veri işlemleri için kullanılan kütüphane.
using System.Data.SqlClient; // SQL işlemleri için kullanılan kütüphane.
using System.Drawing; // Grafik işlemleri için kullanılan kütüphane.
using System.Linq; // Sorgulama işlemleri için kullanılan kütüphane.
using System.Text; // Metin işlemleri için kullanılan kütüphane.
using System.Threading.Tasks; // Çoklu görev programlama desteği için kullanılan kütüphane.
using System.Windows.Forms; // Windows Forms uygulamaları için kullanılan kütüphane.
using System.Data.Sql; // SQL Server için ek işlevsellik sağlayan kütüphane.

namespace Tiyatro // Uygulamanın ad alanı.
{
    public partial class Form2 : Form // Kullanıcı kayıt ekranını tanımlayan sınıf.
    {
        public Form2() // Form2 sınıfının yapıcı metodu.
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
        }

        // SQL bağlantısını tanımlayan değişken.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-F632DVH;Initial Catalog=Tiyatro;Integrated Security=True");
        // SQL bağlantı dizesi, veri kaynağını ve güvenlik modunu içerir.

        // Kayıt ol butonuna tıklandığında çalışacak olay metodu.
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini "Kullanıcılar" tablosuna ekleyen SQL sorgusu.
            string sorgu = "insert into Kullanıcılar(Ad,Soyad,Yaş,Mail,Şifre,TelNo)values(@ad,@soyad,@yas,@mail,@sifre,@tel)";

            // Sorguyu çalıştırmak için SqlCommand nesnesi oluşturuluyor.
            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            // Sorguya kullanıcıdan alınan bilgileri parametre olarak ekliyoruz.
            komut.Parameters.AddWithValue("@ad", txtAd.Text); // Kullanıcı adı.
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text); // Kullanıcı soyadı.
            komut.Parameters.AddWithValue("@yas", txtYas.Text); // Kullanıcı yaşı.
            komut.Parameters.AddWithValue("@mail", txtMail.Text); // Kullanıcı e-posta adresi.
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text); // Kullanıcı şifresi.
            komut.Parameters.AddWithValue("@tel", txtTel.Text); // Kullanıcı telefon numarası.

            baglanti.Open(); // Veritabanı bağlantısını açar.
            komut.ExecuteNonQuery(); // Sorguyu çalıştırır ve veritabanına veriyi ekler.
            MessageBox.Show("Kaydınız başarıyla oluşturulmuştur."); // Başarılı kayıt mesajı.

            // Kayıt işleminden sonra formdaki tüm giriş kutularını temizler.
            txtAd.Clear(); // Ad kutusunu temizler.
            txtSoyad.Clear(); // Soyad kutusunu temizler.
            txtYas.Clear(); // Yaş kutusunu temizler.
            txtMail.Clear(); // E-posta kutusunu temizler.
            txtTel.Clear(); // Telefon kutusunu temizler.
            txtSifre.Clear(); // Şifre kutusunu temizler.

            baglanti.Close(); // Veritabanı bağlantısını kapatır.
        }
    }
}
