using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayıtOtomasyon_173301041
{
    public partial class GirisForm : Form
    {
        public LoginForm _loginForm=null;
        public KullaniciTanitmaOnForm kullanicitanitmaForm=null;
        public PoliklinikTanitmaOnForm _ptoForm = null;
        public HastaIslemleriForm _hastaIslemleriForm = null;     
        private RaporlarForm _raporlarForm = null;
        public Kullanici _user = null;

        public GirisForm()
        {
            InitializeComponent();     
        } 

        public void LoggedIn(Kullanici user)
        {
            this._user = user;
            menuStrip.Enabled = true;
            if(_user.Yetki)
            kullaniciTanitmaToolStripMenuItem.Visible = true;
            poliklinikTanitmaToolStripMenuItem.Visible = true;
        }
        public void LoggedOut()
        {
            _user = null;
            menuStrip.Enabled = false;
            kullaniciTanitmaToolStripMenuItem.Visible = false;
            poliklinikTanitmaToolStripMenuItem.Visible = false;
        }
        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliklinikTanıtmaOnFormKapat();
            HastaIslemleriKapat();
            RaporlarKapat();
            if (kullanicitanitmaForm != null)
            {
                
                if (kullanicitanitmaForm.kullanicitanitmaForm != null)
                {

                    KullaniciTanitmaForm.kullanicitanitmaFormuKapat();
                    kullanicitanitmaForm.kullanicitanitmaForm = null;
                }
            }
            
            kullanicitanitmaForm = KullaniciTanitmaOnForm.KTOFormOlustur(this);
            kullanicitanitmaForm.MdiParent = this;
            kullanicitanitmaForm.Show();
        }
        private void poliklinikTanitmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KulanıcıTanıtmaOnFormKapat();
            HastaIslemleriKapat();
            RaporlarKapat();
            if (_ptoForm != null)
            {
                if (_ptoForm._ptForm != null)
                {
                    PoliklinikTanitmaForm.PTFormuKapat();
                    _ptoForm._ptForm = null;
                }
            }
            _ptoForm = PoliklinikTanitmaOnForm.PTOFormOlustur(this);
            _ptoForm.MdiParent = this;
            _ptoForm.Show();
          

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CıkısYapıldı();
        }
        public void CıkısYapıldı()
        {
            LoggedOut();
            TumPencereleriKapat();
            LoginFormOlustur();
            MessageBox.Show("Başarılı bir şekilde çıkış yapıldı!");
        }
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
           
        }
        private void HastaIslemleriAcılıs()
        {
            KulanıcıTanıtmaOnFormKapat();
            PoliklinikTanıtmaOnFormKapat();
            RaporlarKapat();


            if (_hastaIslemleriForm != null)
            {

                if (_hastaIslemleriForm._hastaBilgileri != null)
                {
                    HastaBilgileriForm.HBFormuKapat();
                    _hastaIslemleriForm._hastaBilgileri = null;
                }

            }
            _hastaIslemleriForm = HastaIslemleriForm.HastaIslemleriFormuOlustur(this);
            _hastaIslemleriForm.StartPosition = FormStartPosition.CenterScreen;
            _hastaIslemleriForm.MdiParent = this;
            _hastaIslemleriForm.Show();
        }
        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KulanıcıTanıtmaOnFormKapat();
            PoliklinikTanıtmaOnFormKapat();
            HastaIslemleriKapat();

            _raporlarForm = RaporlarForm.RaporlarFormOlustur(this);
            _raporlarForm.MdiParent = this;
            _raporlarForm.Show();

        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            LoggedOut();
            LoginFormOlustur();
        }
        private void AnaForm_SizeChanged(object sender, EventArgs e)
        {
            if (_loginForm != null)
            {
                _loginForm.Hide();
                _loginForm.Show();
            }
        }
      
        private void LoginFormOlustur()
        {
            _loginForm = LoginForm.LoginFormOlustur(this);
            _loginForm.StartPosition = FormStartPosition.CenterScreen;
            _loginForm.MdiParent = this;
            _loginForm.Show();
        }

        private void TumPencereleriKapat()
        {
            PoliklinikTanıtmaOnFormKapat();
            KulanıcıTanıtmaOnFormKapat();
            HastaIslemleriKapat();
            RaporlarKapat();
        }
        private void PoliklinikTanıtmaOnFormKapat()
        {
           
            if (_ptoForm != null)
            {

                PoliklinikTanitmaOnForm.PTOFormuKapat();
                _ptoForm = null;
            }
        }
        private void KulanıcıTanıtmaOnFormKapat()
        {
            if (kullanicitanitmaForm != null)
            {
                KullaniciTanitmaOnForm.KTOFormuKapat();
                kullanicitanitmaForm = null;
            }

        }
        private void HastaIslemleriKapat()
        {
            if (_hastaIslemleriForm != null)
            {
                HastaIslemleriForm.HastaIslemleriFormuKapat();
                _hastaIslemleriForm = null;
            }
        }
        private void RaporlarKapat()
        {
            if (_raporlarForm != null)
            {
                RaporlarForm.RaporlarFormuKapat();
                _raporlarForm = null;
            }
        }
        private void hastaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaIslemleriAcılıs();
        }
    }
}
