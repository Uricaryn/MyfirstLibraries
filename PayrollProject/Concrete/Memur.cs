using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollProject.Abstract;

namespace PayrollProject.Concrete
{
    public class Memur : IPersonel
    {
        // Memur sınıfının özel bir alanı: saatlik ücret
        private double _saatlikUcret;

        // Ad özelliği: Memurun adını tutar.
        public string AdSoyad { get; set; }

        // Soyad özelliği: Memurun soyadını tutar.
        public string Title { get; set; }

        // SaatlikUcret özelliği: Memurun saatlik ücretini döndürür.
        public double SaatlikUcret => _saatlikUcret;

        // CalismaSaati özelliği: Memurun çalışma saatlerini tutar.
        public double CalismaSaati { get; set; }

        // BordroAy özelliği: Memurun maaş bordrosunun ait olduğu ayı tutar.
        public string BordroAy { get; set; }

        // Memur sınıfının yapıcı metodu. Saatlik ücreti belirler.
        public Memur(double saatlikUcret)
        {
            _saatlikUcret = saatlikUcret;
        }

        // MaasHesapla metodu: Memurun maaşını hesaplar.
        public double MaasHesapla()
        {
            // Ana maaş: Çalışma saatleri ile saatlik ücret çarpılır.
            double anaMaas = SaatlikUcret * CalismaSaati;
            // Toplam maaş: Ana maaş ile ek mesai ücreti toplanır ve geri döndürülür.
            return anaMaas;

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

