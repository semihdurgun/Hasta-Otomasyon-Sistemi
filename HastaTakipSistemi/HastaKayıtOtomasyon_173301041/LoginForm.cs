using HastaKayıtOtomasyon_173301041;
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
    public partial class LoginForm : Form
    {
        private VeritabanıContext _context;
        private GirisForm _anaForm;
        private static LoginForm loginForm;
       

        protected LoginForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
      
            
        }
        public static LoginForm LoginFormOlustur(GirisForm anaForm)
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm(anaForm);
            }
            else
            {
                loginForm.Show();
            }
            return loginForm;
        }
        public static void LoginFormuKapat()
        {
            if (loginForm != null)
            {
                loginForm.Close();
                loginForm = null;
                
            }
        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (!(textBoxKullaniciAdi.Text.Trim() == "" || textBoxSifre.Text.Trim() == ""))
            {
                string kulAdi = textBoxKullaniciAdi.Text.Trim();
                string sifre = textBoxSifre.Text.Trim();
                bool basariliMi;
                try
                {
                    _context = new VeritabanıContext();
                    Kullanici user = _context.Kullanici.FirstOrDefault(x => x.Username == kulAdi && x.Sifre == sifre);

                    if(user != null)
                    {
                         basariliMi = true;
                    }
                    else
                    {
                        basariliMi = false;

                    }
                    if (basariliMi)
                    {
                        _anaForm.LoggedIn(user);
                        LoginFormuKapat();
                        if (basariliMi)
                        {
                            MessageBox.Show("Oturumunuz açıldı!", "Oturum Açıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Oturumunuz kapatıldı!", "Oturum Kapandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (!basariliMi)
                    {
                        MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre kısımları boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            _anaForm.Close();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Clear();
            textBoxSifre.Clear(); 
        }

        private void buttonGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonGiris_Click(sender, e);
        }

        private void checkBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreyiGoster.Checked)
            {
                //karakteri göster.
                textBoxSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBoxSifre.PasswordChar = '*';
            }
        }
    }
}
