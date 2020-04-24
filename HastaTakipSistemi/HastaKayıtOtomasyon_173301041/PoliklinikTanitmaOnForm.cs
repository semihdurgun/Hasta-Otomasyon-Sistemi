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
    public partial class PoliklinikTanitmaOnForm : Form
    {
        private GirisForm _anaForm = null;
        private static PoliklinikTanitmaOnForm ptoForm = null;
        public PoliklinikTanitmaForm _ptForm = null;
        public VeritabanıContext _context = null;
        public List<Poliklinik> _poliklinikler=null;
        

        protected PoliklinikTanitmaOnForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static PoliklinikTanitmaOnForm PTOFormOlustur(GirisForm anaForm)
        {
            if (ptoForm == null)
            {
                ptoForm = new PoliklinikTanitmaOnForm(anaForm);
           
            }
            else
            {

                ptoForm.Activate();
            }
            return ptoForm;
        }
        public static void PTOFormuKapat()
        {
            if (ptoForm._ptForm != null)
            {
                PoliklinikTanitmaForm.PTFormuKapat();
            }
            ptoForm.Close();
            ptoForm = null;
        }

        private void comboBoxPoliklinikler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBoxPoliklinikler.SelectedItem!= null)
                {
                    string secilenPoliklinik = comboBoxPoliklinikler.SelectedItem.ToString();
                    _ptForm = PoliklinikTanitmaForm.PTFormOlustur(_anaForm);
                    _ptForm.MdiParent = _anaForm;
                    _ptForm.Show();

                  
                }
                else
                {
                    MessageBox.Show("Lütfen bir poliklinik seçiniz..");
                }

            }
                
        }

        private void SelectionCheck()
        {
            if (comboBoxPoliklinikler.SelectedItem != null)
            {
                string secilenPoliklinik = comboBoxPoliklinikler.SelectedItem.ToString();
                try
                {
                    _context = new VeritabanıContext();
                    Poliklinik secilen = _context.Poliklinik.FirstOrDefault(x => x.PoliklinikAdi == secilenPoliklinik);
                    _ptForm = PoliklinikTanitmaForm.PTFormOlustur(_anaForm);
                    _ptForm.PoliklinikEkle(secilen);
                    _ptForm.MdiParent = _anaForm;
                    _ptForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
            MessageBox.Show("Lütfen bir kullanıcı seçiniz .!");
            }
        }
        public void Poliklinikler_Notify()
        {
            try
            {
                comboBoxPoliklinikler.Items.Clear();
                _context = new VeritabanıContext();
                _poliklinikler = _context.Poliklinik.ToList();
                foreach (Poliklinik pol in _poliklinikler)
                {
                    comboBoxPoliklinikler.Items.Add(pol.PoliklinikAdi);
                }
                comboBoxPoliklinikler.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PoliklinikTanitmaOnForm_Shown(object sender, EventArgs e)
        {
            PoliklinikTanitmaForm.PTFormuKapat();
        }

        private void comboBoxPoliklinikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionCheck();
        }

        private void PoliklinikTanitmaOnForm_Load(object sender, EventArgs e)
        {
            Poliklinikler_Notify();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            _ptForm = PoliklinikTanitmaForm.PTFormOlustur(_anaForm);
            _ptForm.PoliklinikEkle(null);
            _ptForm.MdiParent = _anaForm;
            _ptForm.Show();
        }
    }
}
