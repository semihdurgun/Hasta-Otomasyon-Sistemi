namespace HastaKayıtOtomasyon_173301041
{
    partial class RaporlarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporlarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.radioButtonTaburcuOlmus = new System.Windows.Forms.RadioButton();
            this.radioButtonTaburcuOlmamis = new System.Windows.Forms.RadioButton();
            this.radioButtonHepsi = new System.Windows.Forms.RadioButton();
            this.buttonSorgula = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonYazdir = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PoliklinikAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SıraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YapılanIslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taburcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(128, 14);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerBaslangic.TabIndex = 1;
            this.dateTimePickerBaslangic.ValueChanged += new System.EventHandler(this.dateTimePickerBaslangic_ValueChanged);
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBitis.Location = new System.Drawing.Point(128, 64);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerBitis.TabIndex = 1;
            // 
            // radioButtonTaburcuOlmus
            // 
            this.radioButtonTaburcuOlmus.AutoSize = true;
            this.radioButtonTaburcuOlmus.Checked = true;
            this.radioButtonTaburcuOlmus.Location = new System.Drawing.Point(353, 17);
            this.radioButtonTaburcuOlmus.Name = "radioButtonTaburcuOlmus";
            this.radioButtonTaburcuOlmus.Size = new System.Drawing.Size(95, 18);
            this.radioButtonTaburcuOlmus.TabIndex = 2;
            this.radioButtonTaburcuOlmus.TabStop = true;
            this.radioButtonTaburcuOlmus.Text = "Taburcu olmuş";
            this.radioButtonTaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // radioButtonTaburcuOlmamis
            // 
            this.radioButtonTaburcuOlmamis.AutoSize = true;
            this.radioButtonTaburcuOlmamis.Location = new System.Drawing.Point(353, 43);
            this.radioButtonTaburcuOlmamis.Name = "radioButtonTaburcuOlmamis";
            this.radioButtonTaburcuOlmamis.Size = new System.Drawing.Size(105, 18);
            this.radioButtonTaburcuOlmamis.TabIndex = 2;
            this.radioButtonTaburcuOlmamis.Text = "Taburcu olmamış";
            this.radioButtonTaburcuOlmamis.UseVisualStyleBackColor = true;
            // 
            // radioButtonHepsi
            // 
            this.radioButtonHepsi.AutoSize = true;
            this.radioButtonHepsi.Location = new System.Drawing.Point(353, 69);
            this.radioButtonHepsi.Name = "radioButtonHepsi";
            this.radioButtonHepsi.Size = new System.Drawing.Size(52, 18);
            this.radioButtonHepsi.TabIndex = 2;
            this.radioButtonHepsi.Text = "Hepsi";
            this.radioButtonHepsi.UseVisualStyleBackColor = true;
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.BackColor = System.Drawing.Color.Orange;
            this.buttonSorgula.Location = new System.Drawing.Point(519, 20);
            this.buttonSorgula.Name = "buttonSorgula";
            this.buttonSorgula.Size = new System.Drawing.Size(105, 67);
            this.buttonSorgula.TabIndex = 3;
            this.buttonSorgula.Text = "Sorgula";
            this.buttonSorgula.UseVisualStyleBackColor = false;
            this.buttonSorgula.Click += new System.EventHandler(this.buttonSorgula_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.Orange;
            this.buttonTemizle.Location = new System.Drawing.Point(630, 20);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(105, 67);
            this.buttonTemizle.TabIndex = 3;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.BackColor = System.Drawing.Color.Orange;
            this.buttonYazdir.Location = new System.Drawing.Point(741, 20);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(105, 67);
            this.buttonYazdir.TabIndex = 3;
            this.buttonYazdir.Text = "Yazdır";
            this.buttonYazdir.UseVisualStyleBackColor = false;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Orange;
            this.buttonCikis.Location = new System.Drawing.Point(941, 20);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(105, 67);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoliklinikAdi,
            this.SıraNo,
            this.Saat,
            this.YapılanIslem,
            this.DrKodu,
            this.Miktar,
            this.BirimFiyatı,
            this.Tarih,
            this.HastaTC,
            this.HastaAdi,
            this.HastaSoyadi,
            this.Taburcu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 392);
            this.dataGridView1.TabIndex = 4;
            // 
            // PoliklinikAdi
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PoliklinikAdi.DefaultCellStyle = dataGridViewCellStyle4;
            this.PoliklinikAdi.HeaderText = "POLİKLİNİK";
            this.PoliklinikAdi.Name = "PoliklinikAdi";
            this.PoliklinikAdi.ReadOnly = true;
            this.PoliklinikAdi.Width = 120;
            // 
            // SıraNo
            // 
            this.SıraNo.HeaderText = "SIRA NO";
            this.SıraNo.Name = "SıraNo";
            this.SıraNo.ReadOnly = true;
            // 
            // Saat
            // 
            this.Saat.HeaderText = "SAAT";
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            // 
            // YapılanIslem
            // 
            this.YapılanIslem.HeaderText = "YAPILAN İŞLEM";
            this.YapılanIslem.Name = "YapılanIslem";
            this.YapılanIslem.ReadOnly = true;
            this.YapılanIslem.Width = 150;
            // 
            // DrKodu
            // 
            this.DrKodu.HeaderText = "DR.KODU";
            this.DrKodu.Name = "DrKodu";
            this.DrKodu.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "MİKTAR";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // BirimFiyatı
            // 
            this.BirimFiyatı.HeaderText = "BİRİM FİYATI";
            this.BirimFiyatı.Name = "BirimFiyatı";
            this.BirimFiyatı.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // HastaTC
            // 
            this.HastaTC.HeaderText = "HASTA TC";
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.ReadOnly = true;
            // 
            // HastaAdi
            // 
            this.HastaAdi.HeaderText = "Hasta Adı";
            this.HastaAdi.Name = "HastaAdi";
            this.HastaAdi.ReadOnly = true;
            // 
            // HastaSoyadi
            // 
            this.HastaSoyadi.HeaderText = "Hasta Soyadı";
            this.HastaSoyadi.Name = "HastaSoyadi";
            this.HastaSoyadi.ReadOnly = true;
            // 
            // Taburcu
            // 
            this.Taburcu.HeaderText = "TABURCU";
            this.Taburcu.Name = "Taburcu";
            this.Taburcu.ReadOnly = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1060, 549);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonSorgula);
            this.Controls.Add(this.radioButtonHepsi);
            this.Controls.Add(this.radioButtonTaburcuOlmamis);
            this.Controls.Add(this.radioButtonTaburcuOlmus);
            this.Controls.Add(this.dateTimePickerBitis);
            this.Controls.Add(this.dateTimePickerBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1076, 588);
            this.MinimumSize = new System.Drawing.Size(1076, 588);
            this.Name = "RaporlarForm";
            this.Text = "Raporlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaporlarForm_FormClosing);
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.RadioButton radioButtonTaburcuOlmus;
        private System.Windows.Forms.RadioButton radioButtonTaburcuOlmamis;
        private System.Windows.Forms.RadioButton radioButtonHepsi;
        private System.Windows.Forms.Button buttonSorgula;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonYazdir;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoliklinikAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SıraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn YapılanIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyatı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taburcu;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}