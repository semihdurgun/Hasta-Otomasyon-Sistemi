using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace HastaKayıtOtomasyon_173301041
{
    public partial class KullaniciTanitmaForm : Form
    {
        private GirisForm _anaForm;
        private static KullaniciTanitmaForm kullanicitanitmaForm;
        private VeritabanıContext _context;
        Kullanici kullanici = null;
        private bool yetkiDegisti = false;

        protected KullaniciTanitmaForm(GirisForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        public static KullaniciTanitmaForm kullanicitanitmaFormOlustur(GirisForm anaForm)
        {
            if (kullanicitanitmaForm == null)
            {
                kullanicitanitmaForm = new KullaniciTanitmaForm(anaForm);
               
            }
            else
            {
                kullanicitanitmaForm.Location = new Point(0, 0);
                kullanicitanitmaForm.Activate();
            }
            return kullanicitanitmaForm;
        }
        public static void kullanicitanitmaFormuKapat()
        {
            if (kullanicitanitmaForm != null)
            {
                kullanicitanitmaForm.Close();
                kullanicitanitmaForm = null;
            }           
        }

        public void KullaniciEkle(Kullanici kullanici)
        {
            this.kullanici = kullanici;
        }
        private void Kullanici_to_Arayuz_Iliskilendir()
        {
            textBoxKullaniciKodu.Text = kullanici.KullaniciKodu.ToString();

                if (kullanici.TckimlikNo != null)
                    textBoxTCKimlikNo.Text = kullanici.TckimlikNo.ToString();
                if (kullanici.DogumYeri != null)
                    textBoxDogumYeri.Text = kullanici.DogumYeri.ToString();
                if (kullanici.BabaAdi != null)
                    textBoxBabaAdi.Text = kullanici.BabaAdi.ToString();
                if (kullanici.AnneAdi != null)
                    textBoxAnneAdi.Text = kullanici.AnneAdi.ToString();
                if (kullanici.EvTel != null)
                    textBoxTelefonNo.Text = kullanici.EvTel.ToString();
                if (kullanici.CepTel != null)
                    textBoxGSM.Text = kullanici.CepTel.ToString();
                if (kullanici.Unvan != null)
                    comboBoxUnvani.SelectedItem = kullanici.Unvan.ToString();
                if (kullanici.Ad != null)
                    textBoxAdi.Text = kullanici.Ad.ToString();
                if (kullanici.Soyad != null)
                    textBoxSoyadi.Text = kullanici.Soyad.ToString();
                if (kullanici.Maas != null)
                    textBoxMaas.Text = kullanici.Maas.ToString();
                if (kullanici.IseBaslama != null)
                    dateTimePickerIseBaslama.Value = kullanici.IseBaslama.Value;
                if (kullanici.DogumTarihi != null)
                    dateTimePickerDogumTarihi.Value = kullanici.DogumTarihi.Value;
                if (kullanici.Cinsiyet != null)
                    comboBoxCinsiyet.SelectedItem = kullanici.Cinsiyet.ToString();
                if (kullanici.MedeniHal != null)
                    comboBoxMedeniHal.SelectedItem = kullanici.MedeniHal.ToString();
                if (kullanici.KanGrubu != null)
                    comboBoxKanGrubu.SelectedItem = kullanici.KanGrubu.ToString();
                if (kullanici.Adres != null)
                    richTextBoxAdres.Text = kullanici.Adres;

                checkBoxYetkiliKullanici.Checked = kullanici.Yetki;
                textBoxKullaniciAdi.Text = kullanici.Username;
                textBoxSifre.Text = kullanici.Sifre;
         }
        private void Arayuz_to_Kullanici_Iliskilendir(Kullanici kul)
        {
          

            kul.TckimlikNo = textBoxTCKimlikNo.Text.Trim();
            if (textBoxDogumYeri.Text.Trim() != "")
            {
                kul.DogumYeri = textBoxDogumYeri.Text.Trim();
            }
            else
            {
                kul.DogumYeri = null;
            }
            if (textBoxAnneAdi.Text.Trim() != "")
            {
                kul.AnneAdi = textBoxAnneAdi.Text.Trim();
            }
            else
            {
                kul.AnneAdi = null;
            }
            if (textBoxBabaAdi.Text.Trim() != "")
            {
                kul.BabaAdi = textBoxBabaAdi.Text.Trim();
            }
            else
            {
                kul.BabaAdi = null;
            }
            if (textBoxTelefonNo.Text.Trim() != "")
            {
                kul.EvTel = textBoxTelefonNo.Text.Trim();
            }
            else
            {
                kul.EvTel = null;
            }
            if (textBoxGSM.Text.Trim() != "")
            {
                kul.CepTel = textBoxGSM.Text.Trim();
            }
            else
            {
                kul.CepTel = null;
            }
            kul.Yetki = checkBoxYetkiliKullanici.Checked;
            if(comboBoxUnvani.SelectedItem!=null)
            kul.Unvan = comboBoxUnvani.SelectedItem.ToString();
            else
            {
                kul.Unvan = null;
            }
           
                kul.Ad = textBoxAdi.Text.Trim();
                kul.Soyad = textBoxSoyadi.Text.Trim();

            if (textBoxMaas.Text.Trim() != "")
            {
                kul.Maas = textBoxMaas.Text.Trim();
            }
            else
                kul.Maas = null;

            kul.IseBaslama = dateTimePickerIseBaslama.Value;
            kul.DogumTarihi = dateTimePickerDogumTarihi.Value;
            kul.Cinsiyet = comboBoxCinsiyet.SelectedItem.ToString();
            if (comboBoxKanGrubu.SelectedItem != null)
                kul.KanGrubu = comboBoxKanGrubu.SelectedItem.ToString();
            else
                kul.KanGrubu = null;

            kul.MedeniHal = comboBoxMedeniHal.SelectedItem.ToString();
            if (richTextBoxAdres.Text.Trim() != "")
            {
                kul.Adres = richTextBoxAdres.Text.Trim();
            }
            kul.Username = textBoxKullaniciAdi.Text.Trim();
            kul.Sifre = textBoxSifre.Text.Trim();

           

        }
  
        private bool Ekleme_Input_Kontrol( )
        {
            if (textBoxTCKimlikNo.Text.Trim() == "")
            {
                MessageBox.Show("Tc Kimlik No kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;             
            }
            else
            {
                if (textBoxTCKimlikNo.Text.Length != 11)
                {
                    MessageBox.Show("TC Kimlik No kısmı 11 haneli olmalıdır.");
                    return false;
                }
                Kullanici user=null;
                try
                {
                    _context = new VeritabanıContext();

                    if (kullanici != null)
                        user = _context.Kullanici.FirstOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim() && x.KullaniciKodu != kullanici.KullaniciKodu);
                    else
                        user = _context.Kullanici.FirstOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                bool varMi = (user != null) ? true : false;
                // Aynı tcnin dosyada olma kisminida burda kontrol et
                if (varMi )
                {
                    MessageBox.Show("Girilen TC Kimlik No kayıtlarda zaten mevcut, Lütfen düzeltiniz!");
                    return false;
                }
            }
            if (textBoxAdi.Text.Trim() == "")
            {
                MessageBox.Show("Ad Kimlik No kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            if (textBoxSoyadi.Text.Trim() == "")
            {
                MessageBox.Show("Soyad kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            if (comboBoxUnvani.SelectedItem == null)
            {
                MessageBox.Show("Unvan kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            if (comboBoxKanGrubu.SelectedItem == null)
            {
                MessageBox.Show("Kan Grubu kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            if (comboBoxMedeniHal.SelectedItem == null)
            {
                MessageBox.Show("Medeni Hal kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            if (comboBoxCinsiyet.SelectedItem == null)
            {
                MessageBox.Show("Cinsiyet kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            if (textBoxKullaniciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı Adı kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            else
            {
                // Aynı kullaniciAdinin dosyada olma kisminida burda kontrol et
                _context = new VeritabanıContext();
                Kullanici user=null;
                try
                {
                    if (kullanici != null)
                        user = _context.Kullanici.FirstOrDefault(x => x.Username == textBoxKullaniciAdi.Text.Trim() && x.KullaniciKodu != kullanici.KullaniciKodu);
                    else
                        user = _context.Kullanici.FirstOrDefault(x => x.Username == textBoxKullaniciAdi.Text.Trim());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                     
                bool varMi = (user != null) ? true : false;
                if (varMi)
                {
                    MessageBox.Show("Girilen Kullanıcı Adı kayıtlarda bulunmaktadır, Lütfen düzeltiniz!");
                    return false;
                }
            }
            if (textBoxSifre.Text.Trim() == "")
            {
                MessageBox.Show("Şifre kısmı boş olamaz. Lütfen düzeltiniz.");
                return false;
            }
            return true;
       
        }

        private void EklemeVeyaDuzenleme(bool eklemeMi)
        {
            if (eklemeMi)
            {
                buttonKullaniciOlustur.Visible = true;
                buttonSil.Visible = false;
                buttonGuncelle.Visible = false;
            }
            else
            {
                buttonKullaniciOlustur.Visible = false;
                buttonSil.Visible = true;
                buttonGuncelle.Visible = true;
            }
        }
   

        private void KullaniciTanitmaForm_Shown(object sender, EventArgs e)
        {
            kullanicitanitmaForm._anaForm.kullanicitanitmaForm.Hide();
            if (kullanici != null)
            {
                Kullanici_to_Arayuz_Iliskilendir();
                EklemeVeyaDuzenleme(false);
            }
            else
            {
                //Yeni kullanici Ekleme Açılmış demektir
                //Bunun için dosyaki en büyük dosya nonun 1 fazlasını göster
                EklemeVeyaDuzenleme(true);

            }
        }
        private void KullaniciTanitmaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            kullanicitanitmaForm._anaForm.kullanicitanitmaForm.Show();
            kullanicitanitmaForm._anaForm.kullanicitanitmaForm.Kullanicilar_Notify();
            kullanicitanitmaForm = null;
        }
        private void buttonKullaniciOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ekleme_Input_Kontrol())
                {
                    VeritabanıContext context = new VeritabanıContext();
                    kullanici = new Kullanici();
                    Arayuz_to_Kullanici_Iliskilendir(kullanici);
                    context.Kullanici.Add(kullanici);
                    context.SaveChanges();
                    kullanici = _context.Kullanici.SingleOrDefault(x => x.Username == textBoxKullaniciAdi.Text.Trim());
                    textBoxKullaniciKodu.Text = kullanici.KullaniciKodu.ToString();
                    EklemeVeyaDuzenleme(false);
                    
                    MessageBox.Show("Kayıt başarıyla eklendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
                textBoxTCKimlikNo.Text = "";
                textBoxDogumYeri.Text = "";
                textBoxBabaAdi.Text = "";
                textBoxAnneAdi.Text = "";
                textBoxTelefonNo.Text = "";
                textBoxGSM.Text = "";
                textBoxAdi.Text = "";
                textBoxSoyadi.Text = "";
                textBoxMaas.Text = "";
                richTextBoxAdres.Text = "";
                checkBoxYetkiliKullanici.Checked = false;
            MessageBox.Show("Ekran temizlendi!");

        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            
                if (Ekleme_Input_Kontrol())
                {
                    try
                    {
                        _context = new VeritabanıContext();
                        Kullanici kul = _context.Kullanici.SingleOrDefault(x => x.KullaniciKodu == kullanici.KullaniciKodu);
                        Arayuz_to_Kullanici_Iliskilendir(kul);
                        _context.SaveChanges();
                        MessageBox.Show("Kayıt başarıyla güncellendi!", "Güncellendi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Sistemi kullanan kişinin yetkisi değiştirildiğinde oturumun otomatik kapanması gerekir
                        if (!checkBoxYetkiliKullanici.Checked && yetkiDegisti)
                        {
                            if(kullanici.KullaniciKodu == _anaForm._user.KullaniciKodu)
                            _anaForm.CıkısYapıldı();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            MessageBox.Show("Bilgiler güncellendi..");


        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
           
                try
                {                  
                    _context = new VeritabanıContext();
                    var kul = _context.Kullanici.SingleOrDefault(x => x.KullaniciKodu == kullanici.KullaniciKodu);

                    _context.Kullanici.Remove(kul);
                    _context.SaveChanges();
                    MessageBox.Show("Kayıt başarıyla silindi!");
                if (kullanici.KullaniciKodu == _anaForm._user.KullaniciKodu)
                        _anaForm.CıkısYapıldı();
                    else
                        Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            MessageBox.Show("İlgili kişi veritabanından silindi.");

        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void checkBoxYetkiliKullanici_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYetkiliKullanici.Checked)
            {
                yetkiDegisti = false ;
            }
            else
            {
                yetkiDegisti = true;
            }
            
        }
        private void textBoxSadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
