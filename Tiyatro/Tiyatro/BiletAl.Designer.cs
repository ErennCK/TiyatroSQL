namespace Tiyatro
{
    partial class BiletAl
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
            this.components = new System.ComponentModel.Container();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiyatroDataSet = new Tiyatro.TiyatroDataSet();
            this.sehirlerTableAdapter = new Tiyatro.TiyatroDataSetTableAdapters.SehirlerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOyun = new System.Windows.Forms.ComboBox();
            this.oyunlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiyatroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.oyunlarTableAdapter = new Tiyatro.TiyatroDataSetTableAdapters.OyunlarTableAdapter();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTarih = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbKoltuk = new System.Windows.Forms.ComboBox();
            this.sehirlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Fiyat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fKSehirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSehirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbSehir.Location = new System.Drawing.Point(182, 90);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(162, 24);
            this.cmbSehir.TabIndex = 0;
            
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.tiyatroDataSet;
            // 
            // tiyatroDataSet
            // 
            this.tiyatroDataSet.DataSetName = "TiyatroDataSet";
            this.tiyatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehir";
            // 
            // cmbOyun
            // 
            this.cmbOyun.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oyunlarBindingSource, "OyunAdi", true));
            this.cmbOyun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOyun.FormattingEnabled = true;
            this.cmbOyun.Items.AddRange(new object[] {
            "Hamlet",
            "Romeo ve Juliet",
            "Macbeth",
            "Othello",
            "Kral Lear",
            "Bir Yaz Gecesi Rüyası",
            "Fırtına",
            "Vişne Bahçesi",
            "Martı",
            "Vanya Dayı",
            "Üç Kız Kardeş",
            "Godotyu Beklerken",
            "Arzu Tramvayı",
            "Cadı Kazanı",
            "Satıcının Ölümü",
            "Ana Kuraj ve Çocukları",
            "İyi İnsan Şezuandan",
            "Çıkış Yok",
            "Antigone",
            "Kral Oidipus",
            "Ciddi Olmanın Önemi",
            "İdeal Bir Koca",
            "Gergedan",
            "Sandalyeler",
            "Lysistrata",
            "Kurbağalar"});
            this.cmbOyun.Location = new System.Drawing.Point(182, 153);
            this.cmbOyun.Name = "cmbOyun";
            this.cmbOyun.Size = new System.Drawing.Size(162, 24);
            this.cmbOyun.TabIndex = 2;
            // 
            // oyunlarBindingSource
            // 
            this.oyunlarBindingSource.DataMember = "Oyunlar";
            this.oyunlarBindingSource.DataSource = this.tiyatroDataSetBindingSource;
            // 
            // tiyatroDataSetBindingSource
            // 
            this.tiyatroDataSetBindingSource.DataSource = this.tiyatroDataSet;
            this.tiyatroDataSetBindingSource.Position = 0;
            // 
            // oyunlarBindingSource1
            // 
            this.oyunlarBindingSource1.DataMember = "Oyunlar";
            this.oyunlarBindingSource1.DataSource = this.tiyatroDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oyun";
            // 
            // oyunlarTableAdapter
            // 
            this.oyunlarTableAdapter.ClearBeforeFill = true;
            // 
            // cmbSeans
            // 
            this.cmbSeans.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sehirlerBindingSource, "SehirAdi", true));
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Items.AddRange(new object[] {
            "11.45",
            "15.00",
            "17.30",
            "21.00"});
            this.cmbSeans.Location = new System.Drawing.Point(182, 258);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(162, 24);
            this.cmbSeans.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seans";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih";
            // 
            // cmbTarih
            // 
            this.cmbTarih.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sehirlerBindingSource, "SehirAdi", true));
            this.cmbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.Location = new System.Drawing.Point(182, 203);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(162, 24);
            this.cmbTarih.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbKoltuk
            // 
            this.cmbKoltuk.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sehirlerBindingSource, "SehirAdi", true));
            this.cmbKoltuk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoltuk.FormattingEnabled = true;
            this.cmbKoltuk.Location = new System.Drawing.Point(538, 171);
            this.cmbKoltuk.Name = "cmbKoltuk";
            this.cmbKoltuk.Size = new System.Drawing.Size(162, 24);
            this.cmbKoltuk.TabIndex = 11;
            // 
            // sehirlerBindingSource1
            // 
            this.sehirlerBindingSource1.DataMember = "Sehirler";
            this.sehirlerBindingSource1.DataSource = this.tiyatroDataSet;
            // 
            // sehirlerBindingSource2
            // 
            this.sehirlerBindingSource2.DataMember = "Sehirler";
            this.sehirlerBindingSource2.DataSource = this.tiyatroDataSet;
            // 
            // sehirlerBindingSource3
            // 
            this.sehirlerBindingSource3.DataMember = "Sehirler";
            this.sehirlerBindingSource3.DataSource = this.tiyatroDataSet;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Location = new System.Drawing.Point(586, 290);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(0, 16);
            this.Fiyat.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kontrol Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(538, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "Koltuk Düzeni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fKSehirBindingSource
            // 
            this.fKSehirBindingSource.DataMember = "FK_Sehir";
            this.fKSehirBindingSource.DataSource = this.sehirlerBindingSource2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(113, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "KONTROL ET BUTONUNA BASINIZ !!!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(567, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "LÜTFEN BİLGİLERİ DOLDURDUKTAN SONRA SATIN ALIM YAPABİLMEK İÇİN ";
            // 
            // BiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.cmbKoltuk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSeans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOyun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSehir);
            this.Name = "BiletAl";
            this.Text = "BiletAl";
            this.Load += new System.EventHandler(this.BiletAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSehirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSehir;
        private TiyatroDataSet tiyatroDataSet;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private TiyatroDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOyun;
        private System.Windows.Forms.BindingSource tiyatroDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource oyunlarBindingSource;
        private TiyatroDataSetTableAdapters.OyunlarTableAdapter oyunlarTableAdapter;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbKoltuk;
        private System.Windows.Forms.BindingSource sehirlerBindingSource1;
        private System.Windows.Forms.BindingSource oyunlarBindingSource1;
        private System.Windows.Forms.BindingSource sehirlerBindingSource3;
        private System.Windows.Forms.BindingSource sehirlerBindingSource2;
        private System.Windows.Forms.BindingSource fKSehirBindingSource;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}