namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvUyeler = new System.Windows.Forms.Panel();
            this.dgvSorguSonuclari = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antrenoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangictarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeliklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet = new WindowsFormsApp5.fitnessDataSet();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvAntrenorler = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzmanlikalaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antrenorlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAntrenorGuncelle = new System.Windows.Forms.Button();
            this.btnAntrenorSil = new System.Windows.Forms.Button();
            this.btnAntrenorEkle = new System.Windows.Forms.Button();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.txtAntrenorAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPaketler = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pakeradiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aysayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPaketGuncelle = new System.Windows.Forms.Button();
            this.btnPaketSil = new System.Windows.Forms.Button();
            this.btnPaketEkle = new System.Windows.Forms.Button();
            this.txtPaketFiyat = new System.Windows.Forms.TextBox();
            this.txtPaketSure = new System.Windows.Forms.TextBox();
            this.txtPaketAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayittarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUyeGuncelle = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.cmbAntrenorler = new System.Windows.Forms.ComboBox();
            this.cmbPaketler = new System.Windows.Forms.ComboBox();
            this.txtuyetelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtUyesoyadı = new System.Windows.Forms.TextBox();
            this.txtUyeAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uyelerTableAdapter = new WindowsFormsApp5.fitnessDataSetTableAdapters.uyelerTableAdapter();
            this.paketlerTableAdapter = new WindowsFormsApp5.fitnessDataSetTableAdapters.paketlerTableAdapter();
            this.antrenorlerTableAdapter = new WindowsFormsApp5.fitnessDataSetTableAdapters.antrenorlerTableAdapter();
            this.uyeliklerTableAdapter = new WindowsFormsApp5.fitnessDataSetTableAdapters.uyeliklerTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvUyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorguSonuclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeliklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntrenorler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrenorlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.BackColor = System.Drawing.Color.LightGray;
            this.dgvUyeler.Controls.Add(this.tabControl1);
            this.dgvUyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUyeler.Location = new System.Drawing.Point(0, 0);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.Size = new System.Drawing.Size(1604, 881);
            this.dgvUyeler.TabIndex = 1;
            // 
            // dgvSorguSonuclari
            // 
            this.dgvSorguSonuclari.AutoGenerateColumns = false;
            this.dgvSorguSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorguSonuclari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.uyeidDataGridViewTextBoxColumn,
            this.paketidDataGridViewTextBoxColumn,
            this.antrenoridDataGridViewTextBoxColumn,
            this.baslangictarihiDataGridViewTextBoxColumn,
            this.bitistarihiDataGridViewTextBoxColumn});
            this.dgvSorguSonuclari.DataSource = this.uyeliklerBindingSource;
            this.dgvSorguSonuclari.Location = new System.Drawing.Point(234, 331);
            this.dgvSorguSonuclari.Name = "dgvSorguSonuclari";
            this.dgvSorguSonuclari.Size = new System.Drawing.Size(325, 150);
            this.dgvSorguSonuclari.TabIndex = 37;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // uyeidDataGridViewTextBoxColumn
            // 
            this.uyeidDataGridViewTextBoxColumn.DataPropertyName = "uyeid";
            this.uyeidDataGridViewTextBoxColumn.HeaderText = "uyeid";
            this.uyeidDataGridViewTextBoxColumn.Name = "uyeidDataGridViewTextBoxColumn";
            // 
            // paketidDataGridViewTextBoxColumn
            // 
            this.paketidDataGridViewTextBoxColumn.DataPropertyName = "paketid";
            this.paketidDataGridViewTextBoxColumn.HeaderText = "paketid";
            this.paketidDataGridViewTextBoxColumn.Name = "paketidDataGridViewTextBoxColumn";
            // 
            // antrenoridDataGridViewTextBoxColumn
            // 
            this.antrenoridDataGridViewTextBoxColumn.DataPropertyName = "antrenorid";
            this.antrenoridDataGridViewTextBoxColumn.HeaderText = "antrenorid";
            this.antrenoridDataGridViewTextBoxColumn.Name = "antrenoridDataGridViewTextBoxColumn";
            // 
            // baslangictarihiDataGridViewTextBoxColumn
            // 
            this.baslangictarihiDataGridViewTextBoxColumn.DataPropertyName = "baslangictarihi";
            this.baslangictarihiDataGridViewTextBoxColumn.HeaderText = "baslangictarihi";
            this.baslangictarihiDataGridViewTextBoxColumn.Name = "baslangictarihiDataGridViewTextBoxColumn";
            // 
            // bitistarihiDataGridViewTextBoxColumn
            // 
            this.bitistarihiDataGridViewTextBoxColumn.DataPropertyName = "bitistarihi";
            this.bitistarihiDataGridViewTextBoxColumn.HeaderText = "bitistarihi";
            this.bitistarihiDataGridViewTextBoxColumn.Name = "bitistarihiDataGridViewTextBoxColumn";
            // 
            // uyeliklerBindingSource
            // 
            this.uyeliklerBindingSource.DataMember = "uyelikler";
            this.uyeliklerBindingSource.DataSource = this.fitnessDataSet;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "fitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(224, 218);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(92, 49);
            this.btnSorgula.TabIndex = 36;
            this.btnSorgula.Text = "üyeleri sorgulama";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(276, 105);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 35;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(276, 62);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangic.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Bitiş Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Başlangıç Tarihi:";
            // 
            // dgvAntrenorler
            // 
            this.dgvAntrenorler.AutoGenerateColumns = false;
            this.dgvAntrenorler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntrenorler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.adsoyadDataGridViewTextBoxColumn1,
            this.uzmanlikalaniDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn1});
            this.dgvAntrenorler.DataSource = this.antrenorlerBindingSource;
            this.dgvAntrenorler.Location = new System.Drawing.Point(146, 297);
            this.dgvAntrenorler.Name = "dgvAntrenorler";
            this.dgvAntrenorler.Size = new System.Drawing.Size(443, 150);
            this.dgvAntrenorler.TabIndex = 31;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // adsoyadDataGridViewTextBoxColumn1
            // 
            this.adsoyadDataGridViewTextBoxColumn1.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn1.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn1.Name = "adsoyadDataGridViewTextBoxColumn1";
            // 
            // uzmanlikalaniDataGridViewTextBoxColumn
            // 
            this.uzmanlikalaniDataGridViewTextBoxColumn.DataPropertyName = "uzmanlikalani";
            this.uzmanlikalaniDataGridViewTextBoxColumn.HeaderText = "uzmanlikalani";
            this.uzmanlikalaniDataGridViewTextBoxColumn.Name = "uzmanlikalaniDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn1
            // 
            this.telefonDataGridViewTextBoxColumn1.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn1.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn1.Name = "telefonDataGridViewTextBoxColumn1";
            // 
            // antrenorlerBindingSource
            // 
            this.antrenorlerBindingSource.DataMember = "antrenorler";
            this.antrenorlerBindingSource.DataSource = this.fitnessDataSet;
            // 
            // btnAntrenorGuncelle
            // 
            this.btnAntrenorGuncelle.Location = new System.Drawing.Point(164, 238);
            this.btnAntrenorGuncelle.Name = "btnAntrenorGuncelle";
            this.btnAntrenorGuncelle.Size = new System.Drawing.Size(244, 23);
            this.btnAntrenorGuncelle.TabIndex = 30;
            this.btnAntrenorGuncelle.Text = "antrenörü değiştiriniz";
            this.btnAntrenorGuncelle.UseVisualStyleBackColor = true;
            this.btnAntrenorGuncelle.Click += new System.EventHandler(this.btnAntrenorGuncelle_Click);
            // 
            // btnAntrenorSil
            // 
            this.btnAntrenorSil.Location = new System.Drawing.Point(166, 181);
            this.btnAntrenorSil.Name = "btnAntrenorSil";
            this.btnAntrenorSil.Size = new System.Drawing.Size(218, 23);
            this.btnAntrenorSil.TabIndex = 29;
            this.btnAntrenorSil.Text = "antrenör siliniz";
            this.btnAntrenorSil.UseVisualStyleBackColor = true;
            this.btnAntrenorSil.Click += new System.EventHandler(this.btnAntrenorSil_Click);
            // 
            // btnAntrenorEkle
            // 
            this.btnAntrenorEkle.Location = new System.Drawing.Point(164, 140);
            this.btnAntrenorEkle.Name = "btnAntrenorEkle";
            this.btnAntrenorEkle.Size = new System.Drawing.Size(244, 23);
            this.btnAntrenorEkle.TabIndex = 28;
            this.btnAntrenorEkle.Text = "antrenör seçiniz:";
            this.btnAntrenorEkle.UseVisualStyleBackColor = true;
            this.btnAntrenorEkle.Click += new System.EventHandler(this.btnAntrenorEkle_Click);
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(237, 81);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(205, 20);
            this.txtUzmanlik.TabIndex = 27;
            // 
            // txtAntrenorAdSoyad
            // 
            this.txtAntrenorAdSoyad.Location = new System.Drawing.Point(237, 39);
            this.txtAntrenorAdSoyad.Name = "txtAntrenorAdSoyad";
            this.txtAntrenorAdSoyad.Size = new System.Drawing.Size(205, 20);
            this.txtAntrenorAdSoyad.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Uzmanlık Alanı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Antrenör Ad Soyad:";
            // 
            // dgvPaketler
            // 
            this.dgvPaketler.AutoGenerateColumns = false;
            this.dgvPaketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.pakeradiDataGridViewTextBoxColumn,
            this.aysayisiDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dgvPaketler.DataSource = this.paketlerBindingSource;
            this.dgvPaketler.Location = new System.Drawing.Point(91, 328);
            this.dgvPaketler.Name = "dgvPaketler";
            this.dgvPaketler.Size = new System.Drawing.Size(406, 116);
            this.dgvPaketler.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pakeradiDataGridViewTextBoxColumn
            // 
            this.pakeradiDataGridViewTextBoxColumn.DataPropertyName = "pakeradi";
            this.pakeradiDataGridViewTextBoxColumn.HeaderText = "pakeradi";
            this.pakeradiDataGridViewTextBoxColumn.Name = "pakeradiDataGridViewTextBoxColumn";
            // 
            // aysayisiDataGridViewTextBoxColumn
            // 
            this.aysayisiDataGridViewTextBoxColumn.DataPropertyName = "aysayisi";
            this.aysayisiDataGridViewTextBoxColumn.HeaderText = "aysayisi";
            this.aysayisiDataGridViewTextBoxColumn.Name = "aysayisiDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // paketlerBindingSource
            // 
            this.paketlerBindingSource.DataMember = "paketler";
            this.paketlerBindingSource.DataSource = this.fitnessDataSet;
            // 
            // btnPaketGuncelle
            // 
            this.btnPaketGuncelle.Location = new System.Drawing.Point(135, 249);
            this.btnPaketGuncelle.Name = "btnPaketGuncelle";
            this.btnPaketGuncelle.Size = new System.Drawing.Size(115, 23);
            this.btnPaketGuncelle.TabIndex = 22;
            this.btnPaketGuncelle.Text = "paketi değiştir";
            this.btnPaketGuncelle.UseVisualStyleBackColor = true;
            this.btnPaketGuncelle.Click += new System.EventHandler(this.btnPaketGuncelle_Click);
            // 
            // btnPaketSil
            // 
            this.btnPaketSil.Location = new System.Drawing.Point(138, 219);
            this.btnPaketSil.Name = "btnPaketSil";
            this.btnPaketSil.Size = new System.Drawing.Size(99, 23);
            this.btnPaketSil.TabIndex = 21;
            this.btnPaketSil.Text = "paketi sil";
            this.btnPaketSil.UseVisualStyleBackColor = true;
            this.btnPaketSil.Click += new System.EventHandler(this.btnPaketSil_Click);
            // 
            // btnPaketEkle
            // 
            this.btnPaketEkle.Location = new System.Drawing.Point(138, 168);
            this.btnPaketEkle.Name = "btnPaketEkle";
            this.btnPaketEkle.Size = new System.Drawing.Size(112, 23);
            this.btnPaketEkle.TabIndex = 20;
            this.btnPaketEkle.Text = "paket ekleme:";
            this.btnPaketEkle.UseVisualStyleBackColor = true;
            this.btnPaketEkle.Click += new System.EventHandler(this.btnPaketEkle_Click);
            // 
            // txtPaketFiyat
            // 
            this.txtPaketFiyat.Location = new System.Drawing.Point(249, 120);
            this.txtPaketFiyat.Name = "txtPaketFiyat";
            this.txtPaketFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtPaketFiyat.TabIndex = 19;
            // 
            // txtPaketSure
            // 
            this.txtPaketSure.Location = new System.Drawing.Point(258, 82);
            this.txtPaketSure.Name = "txtPaketSure";
            this.txtPaketSure.Size = new System.Drawing.Size(100, 20);
            this.txtPaketSure.TabIndex = 18;
            // 
            // txtPaketAdi
            // 
            this.txtPaketAdi.Location = new System.Drawing.Point(258, 48);
            this.txtPaketAdi.Name = "txtPaketAdi";
            this.txtPaketAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPaketAdi.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fiyat (TL):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Süre (Ay):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "paket adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.kayittarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(110, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // kayittarihiDataGridViewTextBoxColumn
            // 
            this.kayittarihiDataGridViewTextBoxColumn.DataPropertyName = "kayittarihi";
            this.kayittarihiDataGridViewTextBoxColumn.HeaderText = "kayittarihi";
            this.kayittarihiDataGridViewTextBoxColumn.Name = "kayittarihiDataGridViewTextBoxColumn";
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "uyeler";
            this.uyelerBindingSource.DataSource = this.fitnessDataSet;
            // 
            // btnUyeGuncelle
            // 
            this.btnUyeGuncelle.Location = new System.Drawing.Point(110, 276);
            this.btnUyeGuncelle.Name = "btnUyeGuncelle";
            this.btnUyeGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnUyeGuncelle.TabIndex = 12;
            this.btnUyeGuncelle.Text = "üyeyi güncelleyin";
            this.btnUyeGuncelle.UseVisualStyleBackColor = true;
            this.btnUyeGuncelle.Click += new System.EventHandler(this.btnUyeGuncelle_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Location = new System.Drawing.Point(110, 247);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(75, 23);
            this.btnUyeSil.TabIndex = 11;
            this.btnUyeSil.Text = "üyeyi silin";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(110, 205);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(103, 30);
            this.btnUyeEkle.TabIndex = 10;
            this.btnUyeEkle.Text = "üye ekleyin";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // cmbAntrenorler
            // 
            this.cmbAntrenorler.FormattingEnabled = true;
            this.cmbAntrenorler.Location = new System.Drawing.Point(217, 177);
            this.cmbAntrenorler.Name = "cmbAntrenorler";
            this.cmbAntrenorler.Size = new System.Drawing.Size(100, 21);
            this.cmbAntrenorler.TabIndex = 9;
            // 
            // cmbPaketler
            // 
            this.cmbPaketler.FormattingEnabled = true;
            this.cmbPaketler.Location = new System.Drawing.Point(219, 143);
            this.cmbPaketler.Name = "cmbPaketler";
            this.cmbPaketler.Size = new System.Drawing.Size(99, 21);
            this.cmbPaketler.TabIndex = 8;
            // 
            // txtuyetelefon
            // 
            this.txtuyetelefon.Location = new System.Drawing.Point(219, 106);
            this.txtuyetelefon.Name = "txtuyetelefon";
            this.txtuyetelefon.Size = new System.Drawing.Size(100, 20);
            this.txtuyetelefon.TabIndex = 7;
            // 
            // txtUyesoyadı
            // 
            this.txtUyesoyadı.Location = new System.Drawing.Point(219, 73);
            this.txtUyesoyadı.Name = "txtUyesoyadı";
            this.txtUyesoyadı.Size = new System.Drawing.Size(100, 20);
            this.txtUyesoyadı.TabIndex = 6;
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(219, 43);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(100, 20);
            this.txtUyeAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "antrenör seçimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "seçtiği paket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "adı";
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // paketlerTableAdapter
            // 
            this.paketlerTableAdapter.ClearBeforeFill = true;
            // 
            // antrenorlerTableAdapter
            // 
            this.antrenorlerTableAdapter.ClearBeforeFill = true;
            // 
            // uyeliklerTableAdapter
            // 
            this.uyeliklerTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1604, 881);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.images;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnUyeGuncelle);
            this.tabPage1.Controls.Add(this.btnUyeSil);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnUyeEkle);
            this.tabPage1.Controls.Add(this.cmbAntrenorler);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbPaketler);
            this.tabPage1.Controls.Add(this.txtuyetelefon);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtUyesoyadı);
            this.tabPage1.Controls.Add(this.txtUyeAd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1596, 855);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "üye bilgisi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.dgvPaketler);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtPaketAdi);
            this.tabPage2.Controls.Add(this.txtPaketSure);
            this.tabPage2.Controls.Add(this.txtPaketFiyat);
            this.tabPage2.Controls.Add(this.btnPaketEkle);
            this.tabPage2.Controls.Add(this.btnPaketSil);
            this.tabPage2.Controls.Add(this.btnPaketGuncelle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1596, 855);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "paket tercihi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.dgvAntrenorler);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtAntrenorAdSoyad);
            this.tabPage3.Controls.Add(this.txtUzmanlik);
            this.tabPage3.Controls.Add(this.btnAntrenorEkle);
            this.tabPage3.Controls.Add(this.btnAntrenorSil);
            this.tabPage3.Controls.Add(this.btnAntrenorGuncelle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1596, 855);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "antrenör seçimi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.dgvSorguSonuclari);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnSorgula);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.dtpBitis);
            this.tabPage4.Controls.Add(this.dtpBaslangic);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1596, 855);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "üyeler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.dgvUyeler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dgvUyeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorguSonuclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeliklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntrenorler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrenorlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dgvUyeler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUyeGuncelle;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.ComboBox cmbAntrenorler;
        private System.Windows.Forms.ComboBox cmbPaketler;
        private System.Windows.Forms.MaskedTextBox txtuyetelefon;
        private System.Windows.Forms.TextBox txtUyesoyadı;
        private System.Windows.Forms.TextBox txtUyeAd;
        private fitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private fitnessDataSetTableAdapters.uyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayittarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPaketler;
        private System.Windows.Forms.Button btnPaketGuncelle;
        private System.Windows.Forms.Button btnPaketSil;
        private System.Windows.Forms.Button btnPaketEkle;
        private System.Windows.Forms.TextBox txtPaketFiyat;
        private System.Windows.Forms.TextBox txtPaketSure;
        private System.Windows.Forms.TextBox txtPaketAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource paketlerBindingSource;
        private fitnessDataSetTableAdapters.paketlerTableAdapter paketlerTableAdapter;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.TextBox txtAntrenorAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pakeradiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aysayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAntrenorler;
        private System.Windows.Forms.Button btnAntrenorGuncelle;
        private System.Windows.Forms.Button btnAntrenorSil;
        private System.Windows.Forms.Button btnAntrenorEkle;
        private System.Windows.Forms.BindingSource antrenorlerBindingSource;
        private fitnessDataSetTableAdapters.antrenorlerTableAdapter antrenorlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzmanlikalaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvSorguSonuclari;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource uyeliklerBindingSource;
        private fitnessDataSetTableAdapters.uyeliklerTableAdapter uyeliklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antrenoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangictarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

