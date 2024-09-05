using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollProject.Abstract;

namespace PayrollProject.Concrete
{
    public class Yonetici : IPersonel
    {
        // Ad özelliği: Yöneticinin adını tutar.
        public string AdSoyad { get; set; }

        // Soyad özelliği: Yöneticinin soyadını tutar.
        public string Title { get; set; }

        // SaatlikUcret özelliği: Yöneticinin saatlik ücretini sabit olarak 500 olarak döndürür.
        public double SaatlikUcret => 500;

        // Mesai özelliği: Yöneticinin mesai ücretini tutar.
        public double Mesai { get; set; }

        // CalismaSaati özelliği: Yöneticinin çalışma saatlerini tutar.
        public double CalismaSaati { get; set; }

        // BordroAy özelliği: Yöneticinin maaş bordrosunun ait olduğu ayı tutar.
        public string BordroAy { get; set; }


        // MaasHesapla metodu: Yöneticinin maaşını hesaplar.
        public double MaasHesapla()
        {
            // Maaş hesaplanır: Saatlik ücret ile çalışma saati çarpılır ve mesai ücreti eklenir.
            return SaatlikUcret * CalismaSaati + Mesai;
        }

        public double EkmesaiHesapla()
        {
            // Ek mesai ücreti: Çalışma saati 180 saatten fazlaysa ek mesai hesaplanır.
            double ekMesaiUcreti = 0;
            if (CalismaSaati > 180)
            {
                ekMesaiUcreti = (CalismaSaati - 180) * SaatlikUcret * 0.5;
            }
            return ekMesaiUcreti;
        }
    }
}
