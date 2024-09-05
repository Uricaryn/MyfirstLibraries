using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject.Abstract
{
    // IPersonel adında bir arayüz (interface) tanımlıyoruz.
    // Arayüzler, sınıfların implement etmesi gereken metodları ve özellikleri tanımlar.
    // Bu arayüzde personelin sahip olması gereken özellikler ve maaş hesaplama metodu tanımlanmıştır.
    public interface IPersonel
    {
        // Ad özelliği: Personelin adını tutar. Get ve set erişimcileri vardır.
        string AdSoyad { get; set; }

        // Soyad özelliği: Personelin soyadını tutar. Get ve set erişimcileri vardır.
        string Title { get; set; }

        // SaatlikUcret özelliği: Personelin saatlik ücretini tutar. Sadece get erişimcisi vardır.
        double SaatlikUcret { get; }

        // CalismaSaati özelliği: Personelin çalıştığı saatleri tutar. Get ve set erişimcileri vardır.
        double CalismaSaati { get; set; }

        // BordroAy özelliği: Personelin maaş bordrosunun ait olduğu ayı tutar. Get ve set erişimcileri vardır.
        string BordroAy { get; set; }

        // MaasHesapla metodu: Personelin maaşını hesaplar ve döndürür.
        double MaasHesapla();

        double EkmesaiHesapla();
    }
}
