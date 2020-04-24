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
    public partial class PoliklinikTanitmaForm : Form
    {
        private GirisForm _anaForm = null;
        private static PoliklinikTanitmaForm ptForm = null;
        private VeritabanıContext _context = null;
        private Poliklinik _poliklinik = null;

        protected PoliklinikTanitmaForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static PoliklinikTanitmaForm PTFormOlustur(GirisForm anaForm)
        {
            if (ptForm == null)
            {
                ptForm = new PoliklinikTanitmaForm(anaForm);

            }
            else
            {
                ptForm.Activate();
            }
            return ptForm;
        }

        public static void PTFormuKapat()
        {
            if (ptForm != null)
            {
                ptForm.Close();
                ptForm = null;
            }

        }

        public void PoliklinikEkle(Poliklinik pol)
        {
            _poliklinik = pol;
        }
        private void Poliklinik_To_Arayuz_Iliskilendir()
        {
            if (_poliklinik.PoliklinikAdi != null)
            {
                textBoxPoliklinikAdi.Text = _poliklinik.PoliklinikAdi;

            }
            checkBoxGecerli.Checked = _poliklinik.Durum;
            if (_poliklinik.Aciklama != null)
            {
                richTextBoxAciklama.Text = _poliklinik.Aciklama;
            }
        }
        private void Arayuz_To_Poliklinik_Iliskilendir(Poliklinik pol)
        {
            pol.PoliklinikAdi = textBoxPoliklinikAdi.Text.Trim();
            pol.Durum = checkBoxGecerli.Checked;
            if (richTextBoxAciklama.Text.Trim() != null)
            {
                pol.Aciklama = richTextBoxAciklama.Text.Trim();
            }
            else
            {
                pol.Aciklama = null;
            }
        }

        private void PoliklinikTanitmaForm_Shown(object sender, EventArgs e)
        {
            ptForm._anaForm._ptoForm.Hide();
            if (_poliklinik != null)
            {
                Poliklinik_To_Arayuz_Iliskilendir();
                EklemeMi(false);
            }
            else
            {
                EklemeMi(true);
            }
        }

        private void PoliklinikTanitmaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ptForm._anaForm._ptoForm.Show();
            ptForm._anaForm._ptoForm.Poliklinikler_Notify();
            ptForm = null;

        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
                if (!(textBoxPoliklinikAdi.Text.Trim() == ""))
                {
                    try
                    {
                        if (!AynisiVarMi(_poliklinik.PoliklinikId, _poliklinik.PoliklinikAdi))
                        {
                            _context = new VeritabanıContext();
                            var pol = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikId == _poliklinik.PoliklinikId);
                            Arayuz_To_Poliklinik_Iliskilendir(pol);
                            _context.SaveChanges();
                            MessageBox.Show("Kayıt başarıyla güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("Girilen poliklinik adı zaten kullanılmaktadır. Başka bir poliklinik adı giriniz!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
                try
                {

                    _context = new VeritabanıContext();
                    var pol = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikId == _poliklinik.PoliklinikId);
                    _context.Poliklinik.Remove(pol);
                    _context.SaveChanges();
                    MessageBox.Show("Kayıt başarıyla silindi!");
                Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void EklemeMi(bool ekleme)
        {
            if (ekleme)
            {
                panelEkleme.Visible = true;
                panelDuzenle.Visible = false;
            }
            else
            {
                panelEkleme.Visible = false;
                panelDuzenle.Visible = true;
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if ((textBoxPoliklinikAdi.Text.Trim() == ""))
            {
                string polAdi = textBoxPoliklinikAdi.Text.Trim();
                try
                {
                    if (!AynisiVarMi(-1, polAdi))
                    {
                        _context = new VeritabanıContext();
                        Poliklinik yeniPol = new Poliklinik();
                        yeniPol.PoliklinikAdi = polAdi;
                        yeniPol.Durum = checkBoxGecerli.Checked;
                        yeniPol.Aciklama = richTextBoxAciklama.Text;
                        _context.Poliklinik.Add(yeniPol);
                        _context.SaveChanges();

                        _poliklinik = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikAdi == polAdi);

                        Poliklinik_To_Arayuz_Iliskilendir();

                        EklemeMi(false);


                        MessageBox.Show("Kayıt başarıyla eklendi!");

                    }
                    else
                    {
                        MessageBox.Show("Girilen poliklinik adı zaten kullanılmaktadır. Başka bir poliklinik adı giriniz!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool AynisiVarMi(int id, string polAdi)
        {
            try
            {
                _context = new VeritabanıContext();
                List<Poliklinik> pol = null;
                pol = _context.Poliklinik.Where(x => x.PoliklinikId != id && x.PoliklinikAdi == polAdi).ToList();
                if (pol.Count != 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
