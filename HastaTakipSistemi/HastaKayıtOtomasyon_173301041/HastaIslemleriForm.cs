using HastaKayıtOtomasyon_173301041;
using System;
using System.Collections;
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
    public partial class HastaIslemleriForm : Form
    {
        private GirisForm _anaForm;
        private static HastaIslemleriForm hastaIslemleri = null;
        public HastaBilgileriForm _hastaBilgileri = null;
        public DosyaAraForm _dosyaBul = null;
        public TaburcuForm _taburcuForm = null;

        public Hasta _hasta = null;
        private VeritabanıContext _context = null;

        private Poliklinik _secilenPol = null;
        private Islem _secilenIslem = null;
        private Kullanici _secilenDoktor = null;

        private bool oncekiMi = false;

        protected HastaIslemleriForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static HastaIslemleriForm HastaIslemleriFormuOlustur(GirisForm anaForm)
        {
            if (hastaIslemleri == null)
            {
                hastaIslemleri = new HastaIslemleriForm(anaForm);

            }
            else
            {
                hastaIslemleri.Activate();
            }
            return hastaIslemleri;
        }
        public static void HastaIslemleriFormuKapat()
        {
            if (hastaIslemleri != null)
            {
                if (hastaIslemleri._hastaBilgileri != null)
                {
                    HastaBilgileriForm.HBFormuKapat();
                }
                if (hastaIslemleri._dosyaBul != null)
                {
                    DosyaAraForm.DosyaBulFormuKapat();
                }

                hastaIslemleri.Close();
                hastaIslemleri = null;
            }
        }
        public static bool IsOpen()
        {
            if (hastaIslemleri != null)
            {
                return true;
            }
            return false;
        }

        private void HastaIslemleriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HastaBilgileriForm.HBFormuKapat();
            DosyaAraForm.DosyaBulFormuKapat();
            TaburcuForm.TaburcuFormuKapat();
            hastaIslemleri = null;
        }

        private void buttonHastaBilgileri_Click(object sender, EventArgs e)
        {
            _hastaBilgileri = HastaBilgileriForm.HastaBilgileriFormOlustur(_anaForm);
            _hastaBilgileri.MdiParent = _anaForm;
            _hastaBilgileri.HastaEkle(_hasta);
            _hastaBilgileri.Show();

        }

        private void buttonBul_Click(object sender, EventArgs e)
        {
            _dosyaBul = DosyaAraForm.DosyaBulFormOlustur(_anaForm);
            _dosyaBul.MdiParent = _anaForm;
            _dosyaBul.Show();
        }

        private void buttonTaburcu_Click(object sender, EventArgs e)
        {

            if (_hasta != null)
            {
                string date = "";
                if (oncekiMi)
                {
                    date = comboBoxOncekiIslemler.SelectedItem.ToString();

                }
                else
                {
                    DateTime dt = dateTimePickerSevkTarihi.Value;
                    int day = dt.Day;
                    int month = dt.Month;
                    int year = dt.Year;
                    date = year + ":" + month + ":" + day;
                }

                if (!TaburcuKontrol(date))
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        _taburcuForm = TaburcuForm.TaburcuFormOlustur(_anaForm);
                        _taburcuForm.MdiParent = _anaForm;
                        _taburcuForm.Show();
                        _taburcuForm.CikisEkle(_hasta, date);
                    }
                    else
                    {
                        MessageBox.Show("Henüz taburcu edilebilecek bir işlem görünmüyor!");
                    }
                }
                else
                {
                    MessageBox.Show("Hasta bu sevkten zaten taburcu edilmiş.");
                }
            }
            else
            {
                MessageBox.Show("Hastayı seciniz!");
            }

        }

        private bool TaburcuKontrol(string date)
        {
            bool taburcuDurumu = false;
            try
            {
                _context = new VeritabanıContext();

                List<Sevk> sevkler = _context.Sevk.Where(x => x.DosyaNo == _hasta.DosyaNo && x.SevkTarihi == date).ToList();

                foreach (Sevk sevk in sevkler)
                {
                    if (sevk.Taburcu == true)
                    {
                        taburcuDurumu = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return taburcuDurumu;
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            _hasta = null;
            Arayuz_Doldur_Bosalt();
            dataGridView1.Rows.Clear();
            comboBoxOncekiIslemler.Items.Clear();
            labelToplamTutar.Text = "0 TL";

        }

        private void buttonSeçSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("İlgili islem veritabanından silinecektir. Onaylıyor musun?", "Silinecek!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        int index = dataGridView1.CurrentCell.RowIndex;
                        int sevkId = Convert.ToInt32(dataGridView1.Rows[index].Tag);
                        try
                        {
                            _context = new VeritabanıContext();
                            var sevk = _context.Sevk.SingleOrDefault(x => x.SevkId == sevkId);
                            _context.Sevk.Remove(sevk);
                            _context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }



                        if (oncekiMi)
                        {
                            Grid_Guncelle(false);
                        }
                        else
                        {
                            Grid_Guncelle(true);
                        }

                        MessageBox.Show("Başarılı bir şekilde silindi.");
                    }

                }
                else
                {
                    MessageBox.Show("Henüz bir islemi secmediniz!");
                }
            }
            else
            {
                MessageBox.Show("Silinebilecek bir islem bulunamadı!");
            }
        }


        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (_hastaBilgileri != null)
                {
                    _hastaBilgileri.Close();
                }
                if (textBoxDosyaNo.Text.Trim() != "")
                {
                    try
                    {
                        _context = new VeritabanıContext();
                        int dosyaNo = Convert.ToInt32(textBoxDosyaNo.Text);

                        _hasta = _context.Hasta.SingleOrDefault(x => x.DosyaNo == dosyaNo);
                        if (_hasta == null)
                        {
                            MessageBox.Show("Hasta Kaydı bulunamadi!");
                            Arayuz_Doldur_Bosalt();
                            dataGridView1.Rows.Clear();
                            comboBoxOncekiIslemler.Items.Clear();
                            labelToplamTutar.Text = "0 TL";
                        }
                        else
                        {
                            dataGridView1.Rows.Clear();
                            comboBoxOncekiIslemler.Items.Clear();
                            Arayuz_Doldur_Bosalt();

                            Onceki_Islemler_Ekle();
                            Grid_Guncelle(true);
                            oncekiMi = false;


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Dosya No kısmı boş olamaz", "Dosya No giriniz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBoxDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Onceki_Islemler_Ekle()
        {
            if (_hasta != null)
            {
                DateTime dtime = DateTime.Now;

                int day = dtime.Day;
                int month = dtime.Month;
                int year = dtime.Year;
                string date = year + ":" + month + ":" + day;
                List<string> oncekiSevkTarihleri = new List<string>();

                _context = new VeritabanıContext();
                List<Sevk> oncekiSevkler = _context.Sevk.Where(x => x.SevkTarihi != date).ToList();
                if (oncekiSevkler.Count != 0)
                {
                    foreach (Sevk sevk in oncekiSevkler)
                    {
                        if (!oncekiSevkTarihleri.Contains(sevk.SevkTarihi))
                        {
                            oncekiSevkTarihleri.Add(sevk.SevkTarihi);
                        }

                    }

                    foreach (string tarih in oncekiSevkTarihleri)
                    {
                        comboBoxOncekiIslemler.Items.Add(tarih);
                    }
                    comboBoxOncekiIslemler.SelectedIndex = 0;

                }

            }
        }
        public void Arayuz_Doldur_Bosalt()
        {
            if (_hasta != null)
            {
                textBoxDosyaNo.Text = _hasta.DosyaNo.ToString();
                textBoxHastaAdi.Text = _hasta.Ad;
                textBoxHastaSoyadi.Text = _hasta.Soyad;
                textBoxKurumAdi.Text = _hasta.KurumAdi;
            }
            else
            {
                textBoxDosyaNo.Text = "";
                textBoxHastaAdi.Text = "";
                textBoxHastaSoyadi.Text = "";
                textBoxKurumAdi.Text = "";
                comboBoxPoliklinik.SelectedIndex = -1;
                textBoxSiraNo.Text = "";
                comboBoxYapilanIslem.SelectedIndex = -1;
                comboBoxDrNo.SelectedIndex = -1;
                numericUpDownMiktar.Value = 1;
                textBoxBirimFiyat.Text = "0";

            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (!oncekiMi)
            {
                if (_hasta != null)
                {
                    string date = "";
                    if (oncekiMi)
                    {
                        date = comboBoxOncekiIslemler.SelectedItem.ToString();

                    }
                    else
                    {
                        DateTime dt = dateTimePickerSevkTarihi.Value;
                        int day = dt.Day;
                        int month = dt.Month;
                        int year = dt.Year;
                        date = year + ":" + month + ":" + day;
                    }
                    if (TaburcuKontrol(date))
                    {
                        MessageBox.Show("Bu sevk taburcu edildiğinden ekleme yapılamaz.");
                        return;
                    }

                    if (Sevk_Ayarlari_Kontrol())
                    {
                        try
                        {
                            _context = new VeritabanıContext();
                            Sevk sevk = new Sevk();
                            sevk.PoliklinikId = _secilenPol.PoliklinikId;
                            sevk.IslemId = _secilenIslem.IslemId;
                            DateTime dtime = dateTimePickerSevkTarihi.Value;

                            int day = dtime.Day;
                            int month = dtime.Month;
                            int year = dtime.Year;
                            string tarih = year + ":" + month + ":" + day;
                            sevk.SevkTarihi = tarih;
                            string saat = (dtime.Hour.ToString().Length == 1 ? "0" + dtime.Hour : dtime.Hour.ToString()) + ":" + (dtime.Minute.ToString().Length == 1 ? "0" + dtime.Minute : dtime.Minute.ToString());
                            sevk.Saat = saat;
                            sevk.DrKod = _secilenDoktor.KullaniciKodu;
                            sevk.DosyaNo = _hasta.DosyaNo;
                            sevk.Sira = Convert.ToInt32(textBoxSiraNo.Text.Trim());
                            sevk.Miktar = (int)numericUpDownMiktar.Value;
                            sevk.BirimFiyat = _secilenIslem.BirimFiyat;
                            sevk.ToplamTutar = (Convert.ToInt32(_secilenIslem.BirimFiyat) * (int)numericUpDownMiktar.Value).ToString();
                            sevk.Taburcu = false;
                            _context.Sevk.Add(sevk);
                            _context.SaveChanges();

                            Grid_Guncelle(true);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            //tum islemler bitince sevk ayarları bölümünü ve referansları sıfırla!
                            comboBoxPoliklinik.SelectedIndex = -1;
                            textBoxSiraNo.Text = "";
                            comboBoxYapilanIslem.SelectedIndex = -1;
                            comboBoxDrNo.SelectedIndex = -1;
                            numericUpDownMiktar.Value = 1;
                            textBoxBirimFiyat.Text = "";
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Hasta insanı seçiniz!");
                }
            }
            else
            {
                MessageBox.Show("Önceki işlemlere ekleme yapılamaz!");
            }
        }

        private void Grid_Guncelle(bool current)
        {
            string date = "";
            if (current)
            {
                DateTime dt = dateTimePickerSevkTarihi.Value;
                int day = dt.Day;
                int month = dt.Month;
                int year = dt.Year;
                date = year + ":" + month + ":" + day;
            }
            else
            {
                date = comboBoxOncekiIslemler.SelectedItem.ToString();
            }


            try
            {
                _context = new VeritabanıContext();

                var sevkler = _context.Sevk.Where(x => x.DosyaNo == _hasta.DosyaNo && x.SevkTarihi == date).ToList();
                if (sevkler != null)
                    Gride_Ekle(sevkler);
                else
                {
                    MessageBox.Show("Bir sıkıntı oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Gride_Ekle(List<Sevk> sevk)
        {
            dataGridView1.Rows.Clear();
            int toplamTutar = 0;
            for (int i = 0; i < sevk.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Tag = sevk[i].SevkId;
                dataGridView1.Rows[n].Cells[0].Value = sevk[i].Poliklinik.PoliklinikAdi;
                dataGridView1.Rows[n].Cells[1].Value = sevk[i].Sira;
                dataGridView1.Rows[n].Cells[2].Value = sevk[i].Saat;
                dataGridView1.Rows[n].Cells[3].Value = sevk[i].Islem.IslemAdi;
                dataGridView1.Rows[n].Cells[4].Value = sevk[i].DrKod;
                dataGridView1.Rows[n].Cells[5].Value = sevk[i].Miktar;
                dataGridView1.Rows[n].Cells[6].Value = sevk[i].BirimFiyat;
                toplamTutar += Convert.ToInt32(sevk[i].Miktar) * Convert.ToInt32(sevk[i].BirimFiyat);

                for (int j = 0; j < dataGridView1.Rows[n].Cells.Count; j++)
                {
                    dataGridView1.Rows[n].Cells[j].ReadOnly = true;
                }
            }
            labelToplamTutar.Text = toplamTutar + " TL";

        }

        private bool Sevk_Ayarlari_Kontrol()
        {
            if (_secilenPol == null)
            {
                MessageBox.Show("Poliklinik seçiniz!");
                return false;
            }
            if (_secilenIslem == null)
            {

                MessageBox.Show("İslem seçiniz!");
                return false;
            }
            if (_secilenDoktor == null)
            {

                MessageBox.Show("Doktor seçiniz!");
                return false;
            }
            return true;
        }


        private void HastaIslemleriForm_Shown(object sender, EventArgs e)
        {
            PoliklinikleriEkle();
            IslemleriEkle();
            DoktorlariEkle();
        }

        private void PoliklinikleriEkle()
        {
            try
            {
                _context = new VeritabanıContext();
                List<Poliklinik> list = null;
                list = _context.Poliklinik.Where(x => x.Durum == true).ToList();
                foreach (Poliklinik pol in list)
                {
                    comboBoxPoliklinik.Items.Add(pol.PoliklinikAdi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IslemleriEkle()
        {
            try
            {
                _context = new VeritabanıContext();
                List<Islem> list = null;
                list = _context.Islem.ToList();
                foreach (Islem islem in list)
                {
                    comboBoxYapilanIslem.Items.Add(islem.IslemAdi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DoktorlariEkle()
        {
            try
            {
                _context = new VeritabanıContext();
                List<Kullanici> list = null;
                list = _context.Kullanici.Where(x => x.Unvan == "Doktor").ToList();
                foreach (Kullanici doktor in list)
                {
                    comboBoxDrNo.Items.Add(doktor.KullaniciKodu);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPoliklinik.SelectedItem != null)
            {
                string polAdi = comboBoxPoliklinik.SelectedItem.ToString();
                try
                {
                    _context = new VeritabanıContext();
                    _secilenPol = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikAdi == polAdi);
                    if (_secilenPol == null)
                    {
                        MessageBox.Show("Secilen poliklinik veritabanında bulunamadı.");
                    }
                    else
                    {
                        comboBoxYapilanIslem.Enabled = true;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                comboBoxYapilanIslem.Enabled = false;
            }
        }


        private void comboBoxYapilanIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYapilanIslem.SelectedItem != null)
            {
                string yapIslemAdi = comboBoxYapilanIslem.SelectedItem.ToString();
                try
                {
                    _context = new VeritabanıContext();
                    _secilenIslem = _context.Islem.SingleOrDefault(x => x.IslemAdi == yapIslemAdi);
                    if (_secilenIslem == null)
                    {
                        MessageBox.Show("Secilen islem veritabanında bulunamadı.");
                    }
                    else
                    {
                        textBoxSiraNo.Text = SıraVer(yapIslemAdi).ToString();

                        textBoxBirimFiyat.Text = _secilenIslem.BirimFiyat;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private int SıraVer(string islemAdi)
        {
            try
            {
                DateTime dtime = dateTimePickerSevkTarihi.Value;

                int day = dtime.Day;
                int month = dtime.Month;
                int year = dtime.Year;
                string date = year + ":" + month + ":" + day;
                _context = new VeritabanıContext();
                List<Sevk> gelen = _context.Sevk.Where(x => x.SevkTarihi == date && x.Poliklinik.PoliklinikAdi == comboBoxPoliklinik.SelectedItem.ToString().Trim() && x.Islem.IslemAdi == islemAdi).ToList();
                int yeniSira = 1;
                if (gelen.Count != 0)
                {
                    var sonSira = gelen.OrderByDescending(x => x.Sira).FirstOrDefault().Sira;
                    if (sonSira != null)
                    {
                        yeniSira = Convert.ToInt32(sonSira) + 1;
                    }
                    return yeniSira;
                }
                else
                {
                    return yeniSira;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        private void comboBoxDrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrNo.SelectedItem != null)
            {
                int secilenDrKodu = Convert.ToInt32(comboBoxDrNo.SelectedItem);
                try
                {
                    _context = new VeritabanıContext();
                    _secilenDoktor = _context.Kullanici.SingleOrDefault(x => x.KullaniciKodu == secilenDrKodu);
                    if (_secilenDoktor == null)
                    {
                        MessageBox.Show("Secilen doktor veritabanında bulunamadı.");
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonGit_Click(object sender, EventArgs e)
        {
            if (comboBoxOncekiIslemler.SelectedItem != null)
            {

                if (TaburcuKontrol(comboBoxOncekiIslemler.SelectedItem.ToString()))
                {
                    MessageBox.Show("Hasta bu sevkten taburcu edilmiş", "Taburcu Edilmiş!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Grid_Guncelle(false);
                oncekiMi = true;


            }
            else
            {
                if (comboBoxOncekiIslemler.Items.Count == 0)
                {
                    MessageBox.Show("Herhangi bir onceki islem bulunmamaktadir");
                }
                else
                {
                    MessageBox.Show("Herhangi bir onceki islem tarihi secilmemis!");

                }

            }
        }
        private void buttonYazdır_Click(object sender, EventArgs e)
        {
            if (_hasta != null)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    PrintDialog yazdir = new PrintDialog();
                    yazdir.Document = printDocument1;
                    yazdir.UseEXDialog = true;
                    if (yazdir.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                else
                {
                    MessageBox.Show("Henüz bir işlem olmadığı için yazdırma yapılmıyor!");
                }

            }
            else
                MessageBox.Show("Hasta seçimi yapınız..");


        }

        private void buttonBaskıOnizleme_Click(object sender, EventArgs e)
        {
            if (_hasta != null)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                    onizleme.Document = printDocument1;
                    onizleme.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Henüz bir işlem olmadığı için önizkeme yapılmıyor!");
                }
            }
            else
                MessageBox.Show("Hasta seçimi yapınız..");
        }

        Font baslik = new Font("Verdana", 13, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int j = 800;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Rapor Tarih : " + DateTime.Now.Date.ToLongDateString(), govde, brush, 70, 20);
            e.Graphics.DrawString(_hasta.Ad + " " + _hasta.Soyad + " -- Tahlil ve İşlem Sonuçları", baslik, brush, 200, 80);
            e.Graphics.DrawString("Poliklinik       Sıra No     Saat          İşlem     Dr.Kodu     Miktar     Birim", govde, brush, 70, 170);
            e.Graphics.DrawString("---------------------------------------------------------------------------------", govde, brush, 70, 190);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value + "       " +
                    dataGridView1.Rows[i].Cells[1].Value + "        " + dataGridView1.Rows[i].Cells[2].Value + "     " +
                     dataGridView1.Rows[i].Cells[3].Value + "      " + dataGridView1.Rows[i].Cells[4].Value + "     " +
                      dataGridView1.Rows[i].Cells[5].Value + "        " + dataGridView1.Rows[i].Cells[6].Value + "         ", govde, brush, 70, 210 + (i * 30));
                j = i;
            }
            e.Graphics.DrawString("  **Toplam Tutar : " + labelToplamTutar.Text.Trim() + " TL", govde, brush, 100, 210 + (j * 30) + 50);

        }

        private void HastaIslemleriForm_Load(object sender, EventArgs e)
        {
            dateTimePickerSevkTarihi.MaxDate = DateTime.Now;
        }
    }
}
