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
    public partial class TaburcuForm : Form
    {
        private GirisForm _anaForm = null;
        private static TaburcuForm taburcuForm = null;
        private VeritabanıContext _context = null;
        private Hasta _hasta = null;
        private DateTime sevkTarihi;
        private string sevkString;


        protected TaburcuForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        public static TaburcuForm TaburcuFormOlustur(GirisForm anaForm)
        {
            if (taburcuForm == null)
            {
                taburcuForm = new TaburcuForm(anaForm);

            }
            else
            {
                taburcuForm.Activate();
            }
            return taburcuForm;
        }
        public static void TaburcuFormuKapat()
        {
            if (IsOpen())
            {
                taburcuForm.Close();
                taburcuForm = null;
            }

        }
        public static bool IsOpen()
        {
            if (taburcuForm != null)
            {
                return true;
            }
            return false;
        }

        public void CikisEkle(Hasta hasta, string st)
        {
            _hasta = hasta;
            sevkString = st;
            string[] tarih = st.Split(':');
            int yil = Convert.ToInt32(tarih[0]);
            int ay = Convert.ToInt32(tarih[1]);
            int gun = Convert.ToInt32(tarih[2]);
            sevkTarihi = new DateTime(yil, ay, gun);

            ArayuzAyarla();
        }
        private void ArayuzAyarla()
        {
            textBoxDosyaNo.Text = _hasta.DosyaNo.ToString();
            dateTimePickerSevkTarihi.Value = sevkTarihi;
            dateTimePickerCikisTarihi.Value = DateTime.Now.Date;
            textBoxToplamTutar.Text = toplamTutar() + " TL";
        }
        public int toplamTutar()
        {
            int toplam = 0;
            try
            {
                _context = new VeritabanıContext();
                List<Sevk> sevkler = _context.Sevk.Where(x => x.DosyaNo == _hasta.DosyaNo && x.SevkTarihi == sevkString).ToList();
                foreach (Sevk sevk in sevkler)
                {
                    toplam += Convert.ToInt32(sevk.ToplamTutar);
                }

            }
            catch
            {

            }
            return toplam;
        }
        public void TaburcuKaydet()
        {
            try
            {
                _context = new VeritabanıContext();
                var sevkler = _context.Sevk.Where(x => x.DosyaNo == _hasta.DosyaNo && x.SevkTarihi == sevkString).ToList();
                foreach (Sevk sevk in sevkler)
                {
                    sevk.Taburcu = true;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CikisKaydet()
        {
            try
            {
                Cikis cikis = new Cikis();
                cikis.DosyaNo = _hasta.DosyaNo;
                cikis.SevkTarihi = sevkString;
                DateTime dt = DateTime.Now;
                cikis.CikisTarihi = dt.Year + ":" + dt.Month + ":" + dt.Day;
                cikis.Odeme = comboBoxOdemeSekli.SelectedItem.ToString();
                cikis.ToplamTutar = textBoxToplamTutar.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TaburcuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _anaForm._hastaIslemleriForm._taburcuForm = null;
            taburcuForm = null;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxOdemeSekli.SelectedItem != null)
            {
                CikisKaydet();
                TaburcuKaydet();
                Close();
            }
            else
            {
                MessageBox.Show("Bir ödeme tipi seçiniz!");
            }
        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
