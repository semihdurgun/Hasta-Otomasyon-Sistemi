//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaKayıtOtomasyon_173301041
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.Sevk = new HashSet<Sevk>();
        }
    
        public int KullaniciKodu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public bool Yetki { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public string Adres { get; set; }
        public string Unvan { get; set; }
        public Nullable<System.DateTime> IseBaslama { get; set; }
        public string Maas { get; set; }
        public string DogumYeri { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrubu { get; set; }
        public string MedeniHal { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string TckimlikNo { get; set; }
        public string Username { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sevk> Sevk { get; set; }
    }
}
