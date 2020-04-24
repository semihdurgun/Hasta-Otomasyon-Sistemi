namespace HastaKayıtOtomasyon_173301041
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 52);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHATS - LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre :";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(116, 29);
            this.textBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKullaniciAdi.MaxLength = 31;
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(255, 23);
            this.textBoxKullaniciAdi.TabIndex = 1;
            this.textBoxKullaniciAdi.Text = "semih";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(116, 63);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSifre.MaxLength = 31;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(255, 23);
            this.textBoxSifre.TabIndex = 2;
            this.textBoxSifre.Text = "12345";
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGiris.Location = new System.Drawing.Point(9, 122);
            this.buttonGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(99, 58);
            this.buttonGiris.TabIndex = 3;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            this.buttonGiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonGiris_KeyDown);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTemizle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTemizle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonTemizle.Location = new System.Drawing.Point(119, 122);
            this.buttonTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(99, 58);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCikis.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonCikis.Location = new System.Drawing.Point(272, 122);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(99, 58);
            this.buttonCikis.TabIndex = 5;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.checkBoxSifreyiGoster);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonCikis);
            this.panel2.Controls.Add(this.buttonTemizle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonGiris);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxKullaniciAdi);
            this.panel2.Controls.Add(this.textBoxSifre);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 180);
            this.panel2.TabIndex = 7;
            // 
            // checkBoxSifreyiGoster
            // 
            this.checkBoxSifreyiGoster.AutoSize = true;
            this.checkBoxSifreyiGoster.Location = new System.Drawing.Point(116, 90);
            this.checkBoxSifreyiGoster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSifreyiGoster.Name = "checkBoxSifreyiGoster";
            this.checkBoxSifreyiGoster.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSifreyiGoster.TabIndex = 6;
            this.checkBoxSifreyiGoster.Text = "Şifreyi Göster";
            this.checkBoxSifreyiGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreyiGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreyiGoster_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 237);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(379, 237);
            this.MinimumSize = new System.Drawing.Size(379, 237);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSifreyiGoster;
    }
}