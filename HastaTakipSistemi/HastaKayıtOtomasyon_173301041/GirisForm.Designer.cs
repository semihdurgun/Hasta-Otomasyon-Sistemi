namespace HastaKayıtOtomasyon_173301041
{
    partial class GirisForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.referanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanitmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciTanitmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referanslarToolStripMenuItem,
            this.hastaKabulToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // referanslarToolStripMenuItem
            // 
            this.referanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.poliklinikTanitmaToolStripMenuItem,
            this.kullaniciTanitmaToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.referanslarToolStripMenuItem.Name = "referanslarToolStripMenuItem";
            this.referanslarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.referanslarToolStripMenuItem.Text = "Referanslar";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // poliklinikTanitmaToolStripMenuItem
            // 
            this.poliklinikTanitmaToolStripMenuItem.Name = "poliklinikTanitmaToolStripMenuItem";
            this.poliklinikTanitmaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.poliklinikTanitmaToolStripMenuItem.Text = "Poliklinik Tanıtma";
            this.poliklinikTanitmaToolStripMenuItem.Click += new System.EventHandler(this.poliklinikTanitmaToolStripMenuItem_Click);
            // 
            // kullaniciTanitmaToolStripMenuItem
            // 
            this.kullaniciTanitmaToolStripMenuItem.Name = "kullaniciTanitmaToolStripMenuItem";
            this.kullaniciTanitmaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kullaniciTanitmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            this.kullaniciTanitmaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanıtmaToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // hastaKabulToolStripMenuItem
            // 
            this.hastaKabulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaIslemleriToolStripMenuItem});
            this.hastaKabulToolStripMenuItem.Name = "hastaKabulToolStripMenuItem";
            this.hastaKabulToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.hastaKabulToolStripMenuItem.Text = "Hasta Kabul";
            // 
            // hastaIslemleriToolStripMenuItem
            // 
            this.hastaIslemleriToolStripMenuItem.Name = "hastaIslemleriToolStripMenuItem";
            this.hastaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hastaIslemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaIslemleriToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1124, 775);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sağlık Ocağı Otomasyon Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.SizeChanged += new System.EventHandler(this.AnaForm_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem referanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKabulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciTanitmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanitmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaIslemleriToolStripMenuItem;
    }
}



