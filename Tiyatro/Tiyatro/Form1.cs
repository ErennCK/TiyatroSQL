using System; // Temel sistem işlevleri için kullanılan kütüphane.
using System.Collections.Generic; // Koleksiyonlar ve generic yapılar için kütüphane.
using System.ComponentModel; // Bileşenler için kullanılan kütüphane.
using System.Data; // Veri işlemleri için kullanılan kütüphane.
using System.Drawing; // Grafiksel işlemler için kullanılan kütüphane.
using System.Linq; // Sorgulama işlemleri için kullanılan kütüphane.
using System.Text; // Metin işleme için kullanılan kütüphane.
using System.Threading.Tasks; // Çoklu görev programlama desteği için kütüphane.
using System.Windows.Forms; // Windows Forms uygulamaları için kullanılan kütüphane.
using System.Data.SqlClient; // SQL işlemleri için kullanılan kütüphane.
using System.Data.Sql; // SQL Server için ek işlevsellik sağlayan kütüphane.

namespace Tiyatro // Uygulamanın ad alanı.
{
    public partial class Form1 : Form // Giriş ekranı formunu tanımlayan sınıf.
    {
        // Kullanıcı bilgileri için özel değişkenler tanımlanıyor.
        private string kullanici_adi; // Kullanıcının adını saklar.
        private string kullanici_soyadi; // Kullanıcının soyadını saklar.
        private string kullanici_mail; // Kullanıcının e-posta adresini saklar.
        private string kullanici_telno; // Kullanıcının telefon numarasını saklar.

        // Form1 sınıfının yapıcı metodu.
        public Form1()
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
        }

        // SQL bağlantısını tanımlayan değişken.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-F632DVH;Initial Catalog=Tiyatro;Integrated Security=True");
        // SQL bağlantı dizesi, veri kaynağını ve güvenlik modunu içerir.

        // Giriş butonuna tıklandığında çalışacak olay metodu.
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // Veritabanı bağlantısını açar.
            // Kullanıcı adı ve şifreye göre sorgu oluşturulur.
            SqlCommand komut = new SqlCommand("select * from Kullanıcılar where Mail='" + txtKullaniciAdi.Text + "'and Şifre='" + txtSifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader(); // Sorguyu çalıştırır ve sonuçları okur.
            if (dr.Read()) // Eğer sonuç varsa kullanıcı bilgileri alınır.
            {
                kullanici_adi = dr["Ad"].ToString(); // Kullanıcının adı alınır.
                kullanici_soyadi = dr["Soyad"].ToString(); // Kullanıcının soyadı alınır.
                kullanici_mail = dr["Mail"].ToString(); // Kullanıcının e-postası alınır.
                kullanici_telno = dr["TelNo"].ToString(); // Kullanıcının telefon numarası alınır.
                // Ana menü formu, kullanıcı bilgileri ile başlatılır.
                AnaMenuForm frm = new AnaMenuForm(kullanici_adi, kullanici_soyadi, kullanici_mail, kullanici_telno);
                frm.Show(); // Ana menü formu gösterilir.
                this.Hide(); // Giriş formu gizlenir.
            }
            else // Eğer sonuç yoksa, hata mesajı gösterilir.
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı"); // Hatalı giriş mesajı.
            }
            baglanti.Close();
        }

        // Kayıt ol butonuna tıklandığında çalışacak olay metodu.
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2form = new Form2(); // Yeni bir kayıt formu oluşturulur.
            form2form.Show(); // Kayıt formu gösterilir.
        }
    }
}
