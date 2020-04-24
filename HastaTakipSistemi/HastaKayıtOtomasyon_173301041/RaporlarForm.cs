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
    public partial class RaporlarForm : Form
    {
        private GirisForm _anaForm = null;
        private static RaporlarForm raporForm = null;
        private VeritabanıContext _context = null;


        protected RaporlarForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static RaporlarForm RaporlarFormOlustur(GirisForm anaForm)
        {
            if (raporForm == null)
            {
                raporForm = new RaporlarForm(anaForm);
            }
            else
            {
                raporForm.Activate();
            }
            return raporForm;
        }

        public static void RaporlarFormuKapat()
        {
            if (raporForm != null)
            {
                raporForm.Close();
                raporForm = null;
            }
        }

        private void RaporlarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            raporForm = null;
        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                _context = new VeritabanıContext();
                List<Sevk> sevkler = _context.Sevk.ToList();
                List<Sevk> araliktakiSevkler = new List<Sevk>();
                if (sevkler.Count != 0)
                {
                    foreach(Sevk sevk in sevkler)
                    {
                        string[] tarih = sevk.SevkTarihi.Split(':');
                        int yıl = Convert.ToInt32(tarih[0]);
                        int ay = Convert.ToInt32(tarih[1]);
                        int gun = Convert.ToInt32(tarih[2]);
                        DateTime dt = new DateTime(yıl, ay, gun);
                        DateTime bas = dateTimePickerBaslangic.Value;
                        DateTime bit = dateTimePickerBitis.Value;
                        if(dt.Date>=bas.Date && dt.Date <= bit.Date)
                        {
                            araliktakiSevkler.Add(sevk);
                        }
                    }
                    if (radioButtonTaburcuOlmus.Checked)
                    {
                        araliktakiSevkler = araliktakiSevkler.Where(x => x.Taburcu == true).ToList();
                    }
                    else if (radioButtonTaburcuOlmamis.Checked)
                    {
                        araliktakiSevkler = araliktakiSevkler.Where(x => x.Taburcu == false).ToList();
                    }
                    dataGridView1.Rows.Clear();
                    TabloyaYaz(araliktakiSevkler);    
                }
                else
                {
                    MessageBox.Show("Veritabanında hiç bir sevk bulunmamaktadır!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TabloyaYaz(List<Sevk> sevkler)
        {
                dataGridView1.Rows.Clear();
                int toplamTutar = 0;
                for (int i = 0; i < sevkler.Count; i++)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Tag = sevkler[i].SevkId;
                    dataGridView1.Rows[n].Cells[0].Value = sevkler[i].Poliklinik.PoliklinikAdi;
                    dataGridView1.Rows[n].Cells[1].Value = sevkler[i].Sira;
                    dataGridView1.Rows[n].Cells[2].Value = sevkler[i].Saat;
                    dataGridView1.Rows[n].Cells[3].Value = sevkler[i].Islem.IslemAdi;
                    dataGridView1.Rows[n].Cells[4].Value = sevkler[i].DrKod;
                    dataGridView1.Rows[n].Cells[5].Value = sevkler[i].Miktar;
                    dataGridView1.Rows[n].Cells[6].Value = sevkler[i].BirimFiyat;
                    dataGridView1.Rows[n].Cells[7].Value = sevkler[i].SevkTarihi;
                    dataGridView1.Rows[n].Cells[8].Value = sevkler[i].Hasta.TckimlikNo;
                    dataGridView1.Rows[n].Cells[9].Value = sevkler[i].Hasta.Ad;
                    dataGridView1.Rows[n].Cells[10].Value = sevkler[i].Hasta.Soyad;
                    dataGridView1.Rows[n].Cells[11].Value = sevkler[i].Taburcu;
                    toplamTutar += Convert.ToInt32(sevkler[i].Miktar) * Convert.ToInt32(sevkler[i].BirimFiyat);

                    for (int j = 0; j < dataGridView1.Rows[n].Cells.Count; j++)
                    {
                        dataGridView1.Rows[n].Cells[j].ReadOnly = true;
                    }
                }
         }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

     

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePickerBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateTime bas = dateTimePickerBaslangic.Value;
            DateTime bit = dateTimePickerBitis.Value;
            if(bas > bit)
            {
                dateTimePickerBaslangic.Value = bit;
            }
        }
        //Sorgulama Ekranı DataGridView da sevklere dahil bütün bilgileri göster


        private void buttonYazdir_Click(object sender, EventArgs e)
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
        Font altBilgi = new Font("Verdana", 8, FontStyle.Bold);
        Font baslik = new Font("Verdana", 16, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int j = 800;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Rapor Tarih : " + DateTime.Now.Date.ToLongDateString(), govde, brush, 70, 20);
            e.Graphics.DrawString("Poliklinik-Sıra No-Saat-İşlem-Dr.Kodu-Miktar-BirimFiyat-Tarih-Hasta Tc-Adı-Soyadı-Taburcu ", govde, brush, 70, 150);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------", govde, brush, 70, 170);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value + "-" +
                    dataGridView1.Rows[i].Cells[1].Value + "-" + dataGridView1.Rows[i].Cells[2].Value + "-" +
                     dataGridView1.Rows[i].Cells[3].Value + "-" + dataGridView1.Rows[i].Cells[4].Value + "-" +
                      dataGridView1.Rows[i].Cells[5].Value + "-" + dataGridView1.Rows[i].Cells[6].Value + "-" + dataGridView1.Rows[i].Cells[7].Value + "-" + dataGridView1.Rows[i].Cells[8].Value + "-" + dataGridView1.Rows[i].Cells[9].Value + "-" + dataGridView1.Rows[i].Cells[10].Value + "-" + dataGridView1.Rows[i].Cells[11].Value, govde, brush, 70, 190 + (i * 30));
                j = i;
            }
            e.Graphics.DrawString("\n\n\n\n", govde, brush, 70, 150);
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", govde, brush, 70, 190 + (j * 30) + 80);
            e.Graphics.DrawString("**Bu rapor " + dateTimePickerBaslangic.Value + " -- " + dateTimePickerBitis.Value + " tarihleri arasındaki sevkleri gösterir**", altBilgi, brush, 70, 190 + (j * 30) + 100);

        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            dateTimePickerBitis.MaxDate = DateTime.Today;
        }
    }
}
