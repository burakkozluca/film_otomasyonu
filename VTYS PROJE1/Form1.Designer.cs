
namespace VTYS_PROJE1
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
            this.lblAra = new System.Windows.Forms.Label();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxsure = new System.Windows.Forms.TextBox();
            this.tbxbitis_zamani = new System.Windows.Forms.TextBox();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblbitis_zamani = new System.Windows.Forms.Label();
            this.tbxbaslama_zamani = new System.Windows.Forms.TextBox();
            this.tbxkonu = new System.Windows.Forms.TextBox();
            this.lblbaslama_zamani = new System.Windows.Forms.Label();
            this.lblkonu = new System.Windows.Forms.Label();
            this.tbximbd = new System.Windows.Forms.TextBox();
            this.tbxYayin_tarihi = new System.Windows.Forms.TextBox();
            this.lblimbd = new System.Windows.Forms.Label();
            this.lblyayin_tarihi = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.tbxkategori = new System.Windows.Forms.TextBox();
            this.tbxyonetmen = new System.Windows.Forms.TextBox();
            this.lblkategori = new System.Windows.Forms.Label();
            this.lblyonetmen = new System.Windows.Forms.Label();
            this.tbxafis = new System.Windows.Forms.TextBox();
            this.tbxfragman = new System.Windows.Forms.TextBox();
            this.lblafis = new System.Windows.Forms.Label();
            this.lblfragman = new System.Windows.Forms.Label();
            this.tbxyerli = new System.Windows.Forms.TextBox();
            this.lbldil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAra.Location = new System.Drawing.Point(417, 526);
            this.lblAra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(55, 25);
            this.lblAra.TabIndex = 53;
            this.lblAra.Text = "ARA";
            // 
            // tbxAra
            // 
            this.tbxAra.Location = new System.Drawing.Point(843, 608);
            this.tbxAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(226, 31);
            this.tbxAra.TabIndex = 52;
            this.tbxAra.TextChanged += new System.EventHandler(this.tbxAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1533, 377);
            this.dataGridView1.TabIndex = 51;
            // 
            // tbxsure
            // 
            this.tbxsure.Location = new System.Drawing.Point(289, 398);
            this.tbxsure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxsure.Name = "tbxsure";
            this.tbxsure.Size = new System.Drawing.Size(226, 31);
            this.tbxsure.TabIndex = 50;
            // 
            // tbxbitis_zamani
            // 
            this.tbxbitis_zamani.Location = new System.Drawing.Point(289, 345);
            this.tbxbitis_zamani.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxbitis_zamani.Name = "tbxbitis_zamani";
            this.tbxbitis_zamani.Size = new System.Drawing.Size(226, 31);
            this.tbxbitis_zamani.TabIndex = 49;
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.ForeColor = System.Drawing.Color.Black;
            this.lblsure.Location = new System.Drawing.Point(176, 404);
            this.lblsure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(83, 29);
            this.lblsure.TabIndex = 48;
            this.lblsure.Text = "SÜRE";
            // 
            // lblbitis_zamani
            // 
            this.lblbitis_zamani.AutoSize = true;
            this.lblbitis_zamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbitis_zamani.ForeColor = System.Drawing.Color.Black;
            this.lblbitis_zamani.Location = new System.Drawing.Point(80, 351);
            this.lblbitis_zamani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbitis_zamani.Name = "lblbitis_zamani";
            this.lblbitis_zamani.Size = new System.Drawing.Size(179, 29);
            this.lblbitis_zamani.TabIndex = 47;
            this.lblbitis_zamani.Text = "BİTİŞ ZAMANI";
            // 
            // tbxbaslama_zamani
            // 
            this.tbxbaslama_zamani.Location = new System.Drawing.Point(289, 292);
            this.tbxbaslama_zamani.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxbaslama_zamani.Name = "tbxbaslama_zamani";
            this.tbxbaslama_zamani.Size = new System.Drawing.Size(226, 31);
            this.tbxbaslama_zamani.TabIndex = 46;
            // 
            // tbxkonu
            // 
            this.tbxkonu.Location = new System.Drawing.Point(289, 239);
            this.tbxkonu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxkonu.Name = "tbxkonu";
            this.tbxkonu.Size = new System.Drawing.Size(226, 31);
            this.tbxkonu.TabIndex = 45;
            // 
            // lblbaslama_zamani
            // 
            this.lblbaslama_zamani.AutoSize = true;
            this.lblbaslama_zamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslama_zamani.ForeColor = System.Drawing.Color.Black;
            this.lblbaslama_zamani.Location = new System.Drawing.Point(28, 298);
            this.lblbaslama_zamani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbaslama_zamani.Name = "lblbaslama_zamani";
            this.lblbaslama_zamani.Size = new System.Drawing.Size(231, 29);
            this.lblbaslama_zamani.TabIndex = 44;
            this.lblbaslama_zamani.Text = "BAŞLAMA ZAMANI";
            // 
            // lblkonu
            // 
            this.lblkonu.AutoSize = true;
            this.lblkonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkonu.ForeColor = System.Drawing.Color.Black;
            this.lblkonu.Location = new System.Drawing.Point(172, 245);
            this.lblkonu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkonu.Name = "lblkonu";
            this.lblkonu.Size = new System.Drawing.Size(87, 29);
            this.lblkonu.TabIndex = 43;
            this.lblkonu.Text = "KONU";
            // 
            // tbximbd
            // 
            this.tbximbd.Location = new System.Drawing.Point(289, 186);
            this.tbximbd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbximbd.Name = "tbximbd";
            this.tbximbd.Size = new System.Drawing.Size(226, 31);
            this.tbximbd.TabIndex = 42;
            // 
            // tbxYayin_tarihi
            // 
            this.tbxYayin_tarihi.Location = new System.Drawing.Point(289, 133);
            this.tbxYayin_tarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxYayin_tarihi.Name = "tbxYayin_tarihi";
            this.tbxYayin_tarihi.Size = new System.Drawing.Size(226, 31);
            this.tbxYayin_tarihi.TabIndex = 41;
            // 
            // lblimbd
            // 
            this.lblimbd.AutoSize = true;
            this.lblimbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblimbd.ForeColor = System.Drawing.Color.Black;
            this.lblimbd.Location = new System.Drawing.Point(183, 192);
            this.lblimbd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblimbd.Name = "lblimbd";
            this.lblimbd.Size = new System.Drawing.Size(76, 29);
            this.lblimbd.TabIndex = 40;
            this.lblimbd.Text = "IMBD";
            // 
            // lblyayin_tarihi
            // 
            this.lblyayin_tarihi.AutoSize = true;
            this.lblyayin_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyayin_tarihi.ForeColor = System.Drawing.Color.Black;
            this.lblyayin_tarihi.Location = new System.Drawing.Point(80, 139);
            this.lblyayin_tarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblyayin_tarihi.Name = "lblyayin_tarihi";
            this.lblyayin_tarihi.Size = new System.Drawing.Size(179, 29);
            this.lblyayin_tarihi.TabIndex = 39;
            this.lblyayin_tarihi.Text = "YAYIN TARİHİ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(1529, 451);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(270, 84);
            this.btnTemizle.TabIndex = 37;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(289, 80);
            this.tbxAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(226, 31);
            this.tbxAd.TabIndex = 36;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(289, 27);
            this.tbxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(226, 31);
            this.tbxId.TabIndex = 35;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(205, 86);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(54, 29);
            this.lblAd.TabIndex = 34;
            this.lblAd.Text = "ADI";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(221, 33);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(38, 29);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "ID";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGüncelle.Location = new System.Drawing.Point(1214, 451);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(270, 84);
            this.btnGüncelle.TabIndex = 32;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(1844, 451);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(270, 84);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(899, 451);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(270, 84);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.Black;
            this.btnListele.Location = new System.Drawing.Point(584, 451);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(270, 84);
            this.btnListele.TabIndex = 29;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tbxkategori
            // 
            this.tbxkategori.Location = new System.Drawing.Point(289, 610);
            this.tbxkategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxkategori.Name = "tbxkategori";
            this.tbxkategori.Size = new System.Drawing.Size(226, 31);
            this.tbxkategori.TabIndex = 61;
            // 
            // tbxyonetmen
            // 
            this.tbxyonetmen.Location = new System.Drawing.Point(289, 557);
            this.tbxyonetmen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxyonetmen.Name = "tbxyonetmen";
            this.tbxyonetmen.Size = new System.Drawing.Size(226, 31);
            this.tbxyonetmen.TabIndex = 60;
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkategori.ForeColor = System.Drawing.Color.Black;
            this.lblkategori.Location = new System.Drawing.Point(115, 616);
            this.lblkategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(144, 29);
            this.lblkategori.TabIndex = 59;
            this.lblkategori.Text = "KATEGORİ";
            // 
            // lblyonetmen
            // 
            this.lblyonetmen.AutoSize = true;
            this.lblyonetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyonetmen.ForeColor = System.Drawing.Color.Black;
            this.lblyonetmen.Location = new System.Drawing.Point(99, 563);
            this.lblyonetmen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblyonetmen.Name = "lblyonetmen";
            this.lblyonetmen.Size = new System.Drawing.Size(160, 29);
            this.lblyonetmen.TabIndex = 58;
            this.lblyonetmen.Text = "YÖNETMEN";
            // 
            // tbxafis
            // 
            this.tbxafis.Location = new System.Drawing.Point(289, 504);
            this.tbxafis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxafis.Name = "tbxafis";
            this.tbxafis.Size = new System.Drawing.Size(226, 31);
            this.tbxafis.TabIndex = 57;
            // 
            // tbxfragman
            // 
            this.tbxfragman.Location = new System.Drawing.Point(289, 451);
            this.tbxfragman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxfragman.Name = "tbxfragman";
            this.tbxfragman.Size = new System.Drawing.Size(226, 31);
            this.tbxfragman.TabIndex = 56;
            // 
            // lblafis
            // 
            this.lblafis.AutoSize = true;
            this.lblafis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblafis.ForeColor = System.Drawing.Color.Black;
            this.lblafis.Location = new System.Drawing.Point(190, 510);
            this.lblafis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblafis.Name = "lblafis";
            this.lblafis.Size = new System.Drawing.Size(69, 29);
            this.lblafis.TabIndex = 55;
            this.lblafis.Text = "AFİŞ";
            // 
            // lblfragman
            // 
            this.lblfragman.AutoSize = true;
            this.lblfragman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfragman.ForeColor = System.Drawing.Color.Black;
            this.lblfragman.Location = new System.Drawing.Point(121, 457);
            this.lblfragman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfragman.Name = "lblfragman";
            this.lblfragman.Size = new System.Drawing.Size(138, 29);
            this.lblfragman.TabIndex = 54;
            this.lblfragman.Text = "FRAGMAN";
            // 
            // tbxyerli
            // 
            this.tbxyerli.Location = new System.Drawing.Point(289, 663);
            this.tbxyerli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxyerli.Name = "tbxyerli";
            this.tbxyerli.Size = new System.Drawing.Size(226, 31);
            this.tbxyerli.TabIndex = 63;
            // 
            // lbldil
            // 
            this.lbldil.AutoSize = true;
            this.lbldil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldil.ForeColor = System.Drawing.Color.Black;
            this.lbldil.Location = new System.Drawing.Point(207, 669);
            this.lbldil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldil.Name = "lbldil";
            this.lbldil.Size = new System.Drawing.Size(52, 29);
            this.lbldil.TabIndex = 62;
            this.lbldil.Text = "DİL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(705, 608);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "ARAMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2150, 1403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxyerli);
            this.Controls.Add(this.lbldil);
            this.Controls.Add(this.tbxkategori);
            this.Controls.Add(this.tbxyonetmen);
            this.Controls.Add(this.lblkategori);
            this.Controls.Add(this.lblyonetmen);
            this.Controls.Add(this.tbxafis);
            this.Controls.Add(this.tbxfragman);
            this.Controls.Add(this.lblafis);
            this.Controls.Add(this.lblfragman);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxsure);
            this.Controls.Add(this.tbxbitis_zamani);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.lblbitis_zamani);
            this.Controls.Add(this.tbxbaslama_zamani);
            this.Controls.Add(this.tbxkonu);
            this.Controls.Add(this.lblbaslama_zamani);
            this.Controls.Add(this.lblkonu);
            this.Controls.Add(this.tbximbd);
            this.Controls.Add(this.tbxYayin_tarihi);
            this.Controls.Add(this.lblimbd);
            this.Controls.Add(this.lblyayin_tarihi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxsure;
        private System.Windows.Forms.TextBox tbxbitis_zamani;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label lblbitis_zamani;
        private System.Windows.Forms.TextBox tbxbaslama_zamani;
        private System.Windows.Forms.TextBox tbxkonu;
        private System.Windows.Forms.Label lblbaslama_zamani;
        private System.Windows.Forms.Label lblkonu;
        private System.Windows.Forms.TextBox tbximbd;
        private System.Windows.Forms.TextBox tbxYayin_tarihi;
        private System.Windows.Forms.Label lblimbd;
        private System.Windows.Forms.Label lblyayin_tarihi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox tbxkategori;
        private System.Windows.Forms.TextBox tbxyonetmen;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.Label lblyonetmen;
        private System.Windows.Forms.TextBox tbxafis;
        private System.Windows.Forms.TextBox tbxfragman;
        private System.Windows.Forms.Label lblafis;
        private System.Windows.Forms.Label lblfragman;
        private System.Windows.Forms.TextBox tbxyerli;
        private System.Windows.Forms.Label lbldil;
        private System.Windows.Forms.Label label1;
    }
}

