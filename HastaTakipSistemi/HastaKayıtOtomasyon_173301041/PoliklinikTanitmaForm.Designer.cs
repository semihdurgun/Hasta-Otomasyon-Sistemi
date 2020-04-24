namespace HastaKayıtOtomasyon_173301041
{
    partial class PoliklinikTanitmaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPoliklinikAdi = new System.Windows.Forms.TextBox();
            this.checkBoxGecerli = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.panelDuzenle = new System.Windows.Forms.Panel();
            this.panelEkleme = new System.Windows.Forms.Panel();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.panelDuzenle.SuspendLayout();
            this.panelEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // textBoxPoliklinikAdi
            // 
            this.textBoxPoliklinikAdi.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPoliklinikAdi.Location = new System.Drawing.Point(115, 24);
            this.textBoxPoliklinikAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPoliklinikAdi.MaxLength = 50;
            this.textBoxPoliklinikAdi.Name = "textBoxPoliklinikAdi";
            this.textBoxPoliklinikAdi.Size = new System.Drawing.Size(176, 24);
            this.textBoxPoliklinikAdi.TabIndex = 1;
            // 
            // checkBoxGecerli
            // 
            this.checkBoxGecerli.AutoSize = true;
            this.checkBoxGecerli.Font = new System.Drawing.Font("Arial", 11F);
            this.checkBoxGecerli.Location = new System.Drawing.Point(115, 65);
            this.checkBoxGecerli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxGecerli.Name = "checkBoxGecerli";
            this.checkBoxGecerli.Size = new System.Drawing.Size(136, 21);
            this.checkBoxGecerli.TabIndex = 2;
            this.checkBoxGecerli.Text = "Geçerli/Geçersiz";
            this.checkBoxGecerli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Location = new System.Drawing.Point(19, 150);
            this.richTextBoxAciklama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxAciklama.MaxLength = 255;
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.Size = new System.Drawing.Size(272, 154);
            this.richTextBoxAciklama.TabIndex = 3;
            this.richTextBoxAciklama.Text = "";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuncelle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.Green;
            this.buttonGuncelle.Location = new System.Drawing.Point(11, 11);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 38);
            this.buttonGuncelle.TabIndex = 4;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSil.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonSil.ForeColor = System.Drawing.Color.Red;
            this.buttonSil.Location = new System.Drawing.Point(96, 11);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 38);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Orange;
            this.buttonCikis.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonCikis.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonCikis.Location = new System.Drawing.Point(209, 318);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(80, 38);
            this.buttonCikis.TabIndex = 4;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // panelDuzenle
            // 
            this.panelDuzenle.Controls.Add(this.buttonSil);
            this.panelDuzenle.Controls.Add(this.buttonGuncelle);
            this.panelDuzenle.Location = new System.Drawing.Point(19, 307);
            this.panelDuzenle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDuzenle.Name = "panelDuzenle";
            this.panelDuzenle.Size = new System.Drawing.Size(186, 57);
            this.panelDuzenle.TabIndex = 5;
            // 
            // panelEkleme
            // 
            this.panelEkleme.Controls.Add(this.buttonEkle);
            this.panelEkleme.Location = new System.Drawing.Point(19, 307);
            this.panelEkleme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEkleme.Name = "panelEkleme";
            this.panelEkleme.Size = new System.Drawing.Size(186, 57);
            this.panelEkleme.TabIndex = 5;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Orange;
            this.buttonEkle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonEkle.Location = new System.Drawing.Point(11, 11);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(80, 38);
            this.buttonEkle.TabIndex = 4;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // PoliklinikTanitmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(310, 366);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.richTextBoxAciklama);
            this.Controls.Add(this.checkBoxGecerli);
            this.Controls.Add(this.textBoxPoliklinikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelEkleme);
            this.Controls.Add(this.panelDuzenle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PoliklinikTanitmaForm";
            this.Text = "Poliklinik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoliklinikTanitmaForm_FormClosing);
            this.Shown += new System.EventHandler(this.PoliklinikTanitmaForm_Shown);
            this.panelDuzenle.ResumeLayout(false);
            this.panelEkleme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPoliklinikAdi;
        private System.Windows.Forms.CheckBox checkBoxGecerli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Panel panelDuzenle;
        private System.Windows.Forms.Panel panelEkleme;
        private System.Windows.Forms.Button buttonEkle;
    }
}