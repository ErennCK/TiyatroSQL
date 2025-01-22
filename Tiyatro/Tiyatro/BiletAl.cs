using System; // Temel sistem işlevlerini kullanmak için gerekli kütüphane.
using System.Collections.Generic; // List, Dictionary gibi koleksiyonları kullanmak için gerekli kütüphane.
using System.ComponentModel; // Windows Forms için tasarım bileşenlerini kullanmak için gerekli kütüphane.
using System.Data; // Veritabanı işlemleri için gerekli genel veri sınıflarını sağlar.
using System.Data.SqlClient; // SQL bağlantısı ve sorguları için gerekli kütüphane.
using System.Drawing; // Grafik ve görselleştirme işlemleri için gerekli kütüphane.
using System.Linq; // LINQ sorguları yazmak için gerekli kütüphane.
using System.Text; // Metin işleme işlemleri için gerekli kütüphane.
using System.Threading.Tasks; // Çoklu iş parçacığı kullanımı ve görev yönetimi için gerekli kütüphane.
using System.Windows.Forms; // Windows Forms bileşenlerini kullanmak için gerekli kütüphane.
using static System.Windows.Forms.VisualStyles.VisualStyleElement; // Windows görsel stilleri ile ilgili yardımcı sınıfları sağlar.
using System.Data.SqlClient; // SQL veritabanı bağlantıları ve sorguları için gerekli.
using System.Data.Sql; // SQL bağlantı işlemleri için ek destek sağlar.

namespace Tiyatro // Proje için kullanılan ad alanı (namespace).
{
    public partial class BiletAl : Form // Windows Forms sınıfından türetilmiş bir sınıf tanımlanıyor.
    {
        // Kullanıcı bilgilerini saklamak için tanımlanan değişkenler.
        private string kullanici_adi; // Kullanıcının adı.
        private string kullanici_soyadi; // Kullanıcının soyadı.
        private string kullanici_mail; // Kullanıcının e-posta adresi.
        private string kullanici_telno; // Kullanıcının telefon numarası.

        // Yapıcı metot (constructor). Kullanıcı bilgilerini alır ve form bileşenlerini başlatır.
        public BiletAl(string kullanici_adi, string kullanici_soyadi, string kullanici_mail, string kullanici_telno)
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
            this.kullanici_adi = kullanici_adi; // Kullanıcı adı değişkenine parametreyi atar.
            this.kullanici_soyadi = kullanici_soyadi; // Kullanıcı soyadını sınıf değişkenine atar.
            this.kullanici_mail = kullanici_mail; // Kullanıcı e-posta adresini sınıf değişkenine atar.
            this.kullanici_telno = kullanici_telno; // Kullanıcı telefon numarasını sınıf değişkenine atar.
        }

        // Form yüklendiğinde çalışacak olay metodu.
        private void BiletAl_Load(object sender, EventArgs e)
        {
            button1.Enabled = false; // Satın alma butonunu başlangıçta devre dışı bırakır.

            // Bugünden başlayarak 30 gün sonrasına kadar tarihleri tarih seçimi için ComboBox'a ekler.
            DateTime today = DateTime.Today; // Bugünün tarihini alır.

            for (int i = 0; i < 30; i++) // 30 günlük bir döngü oluşturur.
            {
                cmbTarih.Items.Add(today.AddDays(i).ToString("dd.MM.yyyy")); // ComboBox'a tarihleri ekler.
            }

            // ComboBox'ların seçim olaylarını dinlemek için metot bağlama.
            cmbTarih.SelectedIndexChanged += ComboBox_SelectedIndexChanged; // Tarih seçimi değişikliği.
            cmbSehir.SelectedIndexChanged += ComboBox_SelectedIndexChanged; // Şehir seçimi değişikliği.
            cmbSeans.SelectedIndexChanged += ComboBox_SelectedIndexChanged; // Seans seçimi değişikliği.
            cmbOyun.SelectedIndexChanged += ComboBox_SelectedIndexChanged; // Oyun seçimi değişikliği.
        }

        // ComboBox seçim değişikliğini işleyen metot.
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer tüm ComboBox'larda bir seçim yapılmışsa fiyat hesaplaması yapılır.
            if (cmbTarih.SelectedIndex != -1 &&
                cmbSehir.SelectedIndex != -1 &&
                cmbSeans.SelectedIndex != -1 &&
                cmbOyun.SelectedIndex != -1)
            {
                Random random = new Random(); // Rastgele sayı üretmek için Random sınıfı kullanılır.
                int fiyat = random.Next(2, 11) * 50; // Rastgele fiyat oluşturulur (50 ile 500 arasında).

                // Hesaplanan fiyatı bir etiket (label) üzerinde gösterir.
                Fiyat.Text = $"Fiyat: {fiyat} TL";
            }
            else
            {
                Fiyat.Text = ""; // Eğer seçim eksikse fiyat bilgisini temizler.
            }
        }

        // Satın alma butonuna tıklama olayını işleyen metot.
        private void button1_Click(object sender, EventArgs e)
        {
            // ComboBox'larda seçilen değerleri alır.
            string secilenTarih = DateTime.ParseExact(cmbTarih.SelectedItem.ToString(), "dd.MM.yyyy", null)
                                  .ToString("yyyy-MM-dd"); // Tarihi veritabanı formatına dönüştürür.
            string secilenSehir = cmbSehir.SelectedItem.ToString(); // Seçilen şehir.
            string secilenSeans = cmbSeans.SelectedItem.ToString(); // Seçilen seans.
            string secilenOyun = cmbOyun.SelectedItem.ToString(); // Seçilen oyun.
            string secilenKoltuk = cmbKoltuk.SelectedItem.ToString(); // Seçilen koltuk.

            // SQL bağlantısı için connection string.
            string connectionString = @"Data Source=DESKTOP-F632DVH;Initial Catalog=Tiyatro;Integrated Security=True";

            // Bilet bilgilerini veritabanına eklemek için SQL sorgusu.
            string query = @"
                INSERT INTO Biletler (Ad, Soyad, Mail, TelNo, Tarih, Sehir, Seans, Oyun, Koltuk)
                VALUES (@Ad, @Soyad, @Mail, @TelNo, @Tarih, @Sehir, @Seans, @Oyun, @Koltuk)";

            // Veritabanı bağlantısı ve komut işlemleri.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); // Sorguyu tanımlar.
                command.Parameters.AddWithValue("@Tarih", secilenTarih); // Tarih parametresi.
                command.Parameters.AddWithValue("@Sehir", secilenSehir); // Şehir parametresi.
                command.Parameters.AddWithValue("@Seans", secilenSeans); // Seans parametresi.
                command.Parameters.AddWithValue("@Oyun", secilenOyun); // Oyun parametresi.
                command.Parameters.AddWithValue("@Ad", kullanici_adi); // Kullanıcı adı parametresi.
                command.Parameters.AddWithValue("@Soyad", kullanici_soyadi); // Kullanıcı soyadı parametresi.
                command.Parameters.AddWithValue("@Mail", kullanici_mail); // Kullanıcı mail parametresi.
                command.Parameters.AddWithValue("@TelNo", kullanici_telno); // Kullanıcı telefon numarası.
                command.Parameters.AddWithValue("@Koltuk", secilenKoltuk); // Koltuk parametresi.

                try
                {
                    connection.Open(); // Bağlantıyı açar.
                    command.ExecuteNonQuery(); // Sorguyu çalıştırır.
                    MessageBox.Show("Bileti başarıyla satın aldınız!"); // Başarı mesajı gösterir.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message); // Hata durumunda mesaj gösterir.
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatır.
                }
            }

            button1.Enabled = false; // Satın alma butonunu devre dışı bırakır.
            cmbKoltuk.Text = ""; // Koltuk seçimini temizler.
        }

        // Diğer açıklamalar burada devam eder...
        // Koltuk seçimi değişikliğinde çalışacak olay metodu.
        private void cmbKoltuk_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bu metot şu an boş, ancak gelecekte koltuk seçimi ile ilgili ek işlemler yapılabilir.
        }

        // "Koltukları Göster" butonuna tıklanıldığında çalışacak olay metodu.
        private void button2_Click(object sender, EventArgs e)
        {
            // Seçilen kriterleri (tarih, şehir, seans, oyun) alır.
            string secilenTarih = DateTime.ParseExact(cmbTarih.SelectedItem.ToString(), "dd.MM.yyyy", null)
                                  .ToString("yyyy-MM-dd"); // Tarihi veritabanı formatına dönüştürür.
            string secilenSehir = cmbSehir.SelectedItem?.ToString(); // Seçilen şehir.
            string secilenSeans = cmbSeans.SelectedItem?.ToString(); // Seçilen seans.
            string secilenOyun = cmbOyun.SelectedItem?.ToString(); // Seçilen oyun.

            // Eğer herhangi bir seçim eksikse kullanıcıya uyarı mesajı gösterir ve metodu sonlandırır.
            if (string.IsNullOrEmpty(secilenTarih) || string.IsNullOrEmpty(secilenSehir) ||
                string.IsNullOrEmpty(secilenSeans) || string.IsNullOrEmpty(secilenOyun))
            {
                MessageBox.Show("Lütfen tüm seçimleri yapınız."); // Uyarı mesajı.
                return; // Metodu sonlandırır.
            }

            // SQL bağlantı dizesi tanımlanır.
            string connectionString = @"Data Source=DESKTOP-F632DVH;Initial Catalog=Tiyatro;Integrated Security=True";

            // Veritabanından dolu koltukları getiren SQL sorgusu.
            string query = @"
                SELECT Koltuk FROM Biletler
                WHERE Tarih = @Tarih AND Sehir = @Sehir AND Seans = @Seans AND Oyun = @Oyun";

            List<string> doluKoltuklar = new List<string>(); // Dolu koltukları tutmak için liste oluşturulur.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); // SQL sorgusu hazırlanır.
                command.Parameters.AddWithValue("@Tarih", secilenTarih); // Tarih parametresi eklenir.
                command.Parameters.AddWithValue("@Sehir", secilenSehir); // Şehir parametresi eklenir.
                command.Parameters.AddWithValue("@Seans", secilenSeans); // Seans parametresi eklenir.
                command.Parameters.AddWithValue("@Oyun", secilenOyun); // Oyun parametresi eklenir.

                try
                {
                    connection.Open(); // Veritabanı bağlantısını açar.
                    SqlDataReader reader = command.ExecuteReader(); // Sorguyu çalıştırır ve sonuçları okur.

                    // Sorgudan dönen dolu koltukları listeye ekler.
                    while (reader.Read())
                    {
                        doluKoltuklar.Add(reader.GetString(0)); // Koltuk numarasını listeye ekler.
                    }

                    reader.Close(); // Okuyucuyu kapatır.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message); // Hata durumunda mesaj gösterir.
                }
            }

            // Tüm koltukları yeniden oluştur ve dolu koltukları hariç tut.
            cmbKoltuk.Items.Clear(); // Koltuk seçimi için ComboBox temizlenir.
            string[] kolonlar = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" }; // Salonun kolon harfleri.

            for (int i = 0; i < kolonlar.Length; i++) // Her bir kolon için döngü.
            {
                for (int j = 1; j <= 26; j++) // 1'den 26'ya kadar koltuk numaraları.
                {
                    string koltukNo = $"{kolonlar[i]}{j}"; // Koltuk numarasını oluşturur.

                    if (!doluKoltuklar.Contains(koltukNo)) // Eğer koltuk dolu değilse...
                    {
                        cmbKoltuk.Items.Add(koltukNo); // Koltuk ComboBox'a eklenir.
                    }
                }
            }

            MessageBox.Show("Koltuk seçme işlemine devam edebilirsiniz."); // Kullanıcıya işlem tamam mesajı.

            button1.Enabled = true; // Satın alma butonunu etkinleştirir.
        }

        // "Fotoğraf Görüntüle" butonuna tıklanıldığında çalışacak olay metodu.
        private void button3_Click(object sender, EventArgs e)
        {
            Foto ft = new Foto(); // Yeni bir Foto formu oluşturur.
            ft.Show(); // Foto formunu gösterir.
        }
    }
}
