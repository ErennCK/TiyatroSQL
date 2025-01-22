using System; // Temel sistem işlevleri için kullanılan kütüphane.
using System.Collections.Generic; // Koleksiyonlar ve generic yapılar için kullanılan kütüphane.
using System.ComponentModel; // Bileşenler için kullanılan kütüphane.
using System.Data; // Veri işlemleri için kullanılan kütüphane.
using System.Drawing; // Grafik işlemleri için kullanılan kütüphane.
using System.Linq; // Sorgulama işlemleri için kullanılan kütüphane.
using System.Text; // Metin işlemleri için kullanılan kütüphane.
using System.Threading.Tasks; // Çoklu görev programlama desteği için kullanılan kütüphane.
using System.Windows.Forms; // Windows Forms uygulamaları için kullanılan kütüphane.
using System.Data.SqlClient; // SQL işlemleri için kullanılan kütüphane.
using System.Data.Sql; // SQL Server için ek işlevsellik sağlayan kütüphane.

namespace Tiyatro // Uygulamanın ad alanı.
{
    public partial class Biletlerim : Form // Kullanıcının biletlerini görüntülemesini sağlayan sınıf.
    {
        // Kullanıcı bilgileri için özel değişkenler tanımlanıyor.
        private string kullanici_adi; // Kullanıcının adı.
        private string kullanici_soyadi; // Kullanıcının soyadı.
        private string kullanici_mail; // Kullanıcının e-posta adresi.
        private string kullanici_telno; // Kullanıcının telefon numarası.

        // Biletlerim sınıfının yapıcı metodu.
        public Biletlerim(string kullanici_adi, string kullanici_soyadi, string kullanici_mail, string kullanici_telno)
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
            this.kullanici_adi = kullanici_adi; // Kullanıcı adını ayarlar.
            this.kullanici_soyadi = kullanici_soyadi; // Kullanıcı soyadını ayarlar.
            this.kullanici_mail = kullanici_mail; // Kullanıcı e-postasını ayarlar.
            this.kullanici_telno = kullanici_telno; // Kullanıcı telefon numarasını ayarlar.
        }

        // Form yüklendiğinde çalışacak olay metodu.
        private void Biletlerim_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantı dizesi.
            string connectionString = @"Data Source=DESKTOP-F632DVH;Initial Catalog=Tiyatro;Integrated Security=True";

            // Kullanıcıya ait biletleri seçmek için SQL sorgusu.
            string query = @"
                SELECT BiletID, Tarih, Sehir, Seans, Oyun, Koltuk
                FROM Biletler 
                WHERE Mail = @Mail";

            // SQL bağlantısı oluşturuluyor.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL komutunu oluştur ve parametre ekle.
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Mail", kullanici_mail); // Giriş yapan kullanıcının e-postasını kullanır.

                try
                {
                    connection.Open(); // Veritabanı bağlantısını açar.
                    SqlDataAdapter adapter = new SqlDataAdapter(command); // Verileri almak için adapter kullanılır.
                    DataTable dataTable = new DataTable(); // Veriler bir tabloya yüklenecek.
                    adapter.Fill(dataTable); // Tabloyu SQL sorgusundan alınan verilerle doldur.

                    // DataGridView'e verileri yükle.
                    dataGridViewBiletler.DataSource = dataTable; // Verileri DataGridView'e bağlar.
                }
                catch (Exception ex) // Veri yükleme sırasında hata oluşursa.
                {
                    // Hata mesajını göster.
                    MessageBox.Show("Veri yükleme hatası: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Veritabanı bağlantısını kapat.
                }
            }
        }

        // Bir link tıklanırsa çalışacak olay metodu.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Şu an boş; özel bir işlev tanımlanabilir.
        }

        // DataGridView hücresi tıklanırsa çalışacak olay metodu.
        private void dataGridViewBiletler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Şu an boş; özel bir işlev tanımlanabilir.
        }
    }
}
