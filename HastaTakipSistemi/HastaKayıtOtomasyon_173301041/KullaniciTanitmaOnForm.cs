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
    public partial class KullaniciTanitmaOnForm : Form
    {
        private GirisForm _anaForm;
        private static KullaniciTanitmaOnForm ktoForm;
        public KullaniciTanitmaForm kullanicitanitmaForm;
        public List<Kullanici> _kullanicilar = null;
        private VeritabanıContext _context;

        protected KullaniciTanitmaOnForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        public static KullaniciTanitmaOnForm KTOFormOlustur(GirisForm anaForm)
        {
            if (ktoForm == null)
            {
                ktoForm = new KullaniciTanitmaOnForm(anaForm);

            }
            else
            {
                ktoForm.Activate();
            }
            return ktoForm;
        }
        public static void KTOFormuKapat()
        {
            if (ktoForm.kullanicitanitmaForm != null)
            {
                KullaniciTanitmaForm.kullanicitanitmaFormuKapat();
            }
            ktoForm.Close();
            ktoForm = null;
        }

        private void buttonKullaniciEkle_Click(object sender, EventArgs e)
        {
            kullanicitanitmaForm = KullaniciTanitmaForm.kullanicitanitmaFormOlustur(_anaForm);
            kullanicitanitmaForm.MdiParent = _anaForm;
            kullanicitanitmaForm.Show();


        }

        private void comboBoxKullanicilar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectionCheck();
            }
        }

        private void KullaniciTanitmaOnForm_Shown(object sender, EventArgs e)
        {
            KullaniciTanitmaForm.kullanicitanitmaFormuKapat();
        }

        private void KullaniciTanitmaOnForm_Load(object sender, EventArgs e)
        {
            Kullanicilar_Notify();
        }

        public void Kullanicilar_Notify()
        {
            try
            {
                comboBoxKullanicilar.Items.Clear();
                _context = new VeritabanıContext();
                _kullanicilar = _context.Kullanici.ToList();
                foreach (Kullanici kul in _kullanicilar)
                {
                    comboBoxKullanicilar.Items.Add(kul.Username);
                }
                comboBoxKullanicilar.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionCheck();
        }

        private void SelectionCheck()
        {
            if (comboBoxKullanicilar.SelectedItem != null)
            {
                string secilenUsername = comboBoxKullanicilar.SelectedItem.ToString();
                try
                {
                    _context = new VeritabanıContext();
                    Kullanici secilenKullanici = _context.Kullanici.FirstOrDefault(x => x.Username == secilenUsername);
                    kullanicitanitmaForm = KullaniciTanitmaForm.kullanicitanitmaFormOlustur(_anaForm);
                    kullanicitanitmaForm.KullaniciEkle(secilenKullanici);
                    kullanicitanitmaForm.MdiParent = _anaForm;
                    kullanicitanitmaForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı seçiniz!");
            }
        }
    }
}
