namespace HastaKayıtOtomasyon_173301041
{
    partial class KullaniciTanitmaOnForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKullanicilar = new System.Windows.Forms.ComboBox();
            this.buttonKullaniciEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 50);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHATS - Kullanıcı Tanıtma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Kodu ";
            // 
            // comboBoxKullanicilar
            // 
            this.comboBoxKullanicilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKullanicilar.FormattingEnabled = true;
            this.comboBoxKullanicilar.Location = new System.Drawing.Point(140, 66);
            this.comboBoxKullanicilar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxKullanicilar.Name = "comboBoxKullanicilar";
            this.comboBoxKullanicilar.Size = new System.Drawing.Size(132, 21);
            this.comboBoxKullanicilar.TabIndex = 9;
            this.comboBoxKullanicilar.SelectedIndexChanged += new System.EventHandler(this.comboBoxKullanicilar_SelectedIndexChanged);
            this.comboBoxKullanicilar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKullanicilar_KeyDown);
            // 
            // buttonKullaniciEkle
            // 
            this.buttonKullaniciEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonKullaniciEkle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKullaniciEkle.ForeColor = System.Drawing.Color.Green;
            this.buttonKullaniciEkle.Location = new System.Drawing.Point(70, 100);
            this.buttonKullaniciEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKullaniciEkle.Name = "buttonKullaniciEkle";
            this.buttonKullaniciEkle.Size = new System.Drawing.Size(152, 39);
            this.buttonKullaniciEkle.TabIndex = 10;
            this.buttonKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.buttonKullaniciEkle.UseVisualStyleBackColor = false;
            this.buttonKullaniciEkle.Click += new System.EventHandler(this.buttonKullaniciEkle_Click);
            // 
            // KullaniciTanitmaOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(292, 160);
            this.Controls.Add(this.buttonKullaniciEkle);
            this.Controls.Add(this.comboBoxKullanicilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KullaniciTanitmaOnForm";
            this.Text = "KullaniciTanitmaOnForm";
            this.Load += new System.EventHandler(this.KullaniciTanitmaOnForm_Load);
            this.Shown += new System.EventHandler(this.KullaniciTanitmaOnForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKullanicilar;
        private System.Windows.Forms.Button buttonKullaniciEkle;
    }
}