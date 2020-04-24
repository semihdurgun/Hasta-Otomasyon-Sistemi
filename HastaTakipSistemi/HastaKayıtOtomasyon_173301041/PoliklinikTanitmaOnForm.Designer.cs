namespace HastaKayıtOtomasyon_173301041
{
    partial class PoliklinikTanitmaOnForm
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
            this.comboBoxPoliklinikler = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 46);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHATS - Poliklinik Tanıtma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Poliklinik Adı";
            // 
            // comboBoxPoliklinikler
            // 
            this.comboBoxPoliklinikler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPoliklinikler.FormattingEnabled = true;
            this.comboBoxPoliklinikler.Location = new System.Drawing.Point(103, 65);
            this.comboBoxPoliklinikler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPoliklinikler.Name = "comboBoxPoliklinikler";
            this.comboBoxPoliklinikler.Size = new System.Drawing.Size(132, 21);
            this.comboBoxPoliklinikler.TabIndex = 10;
            this.comboBoxPoliklinikler.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoliklinikler_SelectedIndexChanged);
            this.comboBoxPoliklinikler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPoliklinikler_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(103, 99);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Geçerli/Geçersiz";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Magenta;
            this.buttonEkle.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEkle.Location = new System.Drawing.Point(103, 135);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(128, 36);
            this.buttonEkle.TabIndex = 12;
            this.buttonEkle.Text = "Poliklinik Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // PoliklinikTanitmaOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(306, 215);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxPoliklinikler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PoliklinikTanitmaOnForm";
            this.Text = "PoliklinikTanıtmaOnForm";
            this.Load += new System.EventHandler(this.PoliklinikTanitmaOnForm_Load);
            this.Shown += new System.EventHandler(this.PoliklinikTanitmaOnForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPoliklinikler;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonEkle;
    }
}