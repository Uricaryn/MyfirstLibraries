using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PayrollProject.Abstract;

namespace PayrollProject.Concrete
{
    public class Payroll
    {
        // MaaslariHesaplaVeKaydet metodu: Personel listesinin maaşlarını hesaplar ve dosyaya kaydeder.
        public void MaaslariHesaplaVeKaydet<T>(List<T> personelListesi) where T : IPersonel
        {
            // Personel listesinin boş olup olmadığını kontrol eder.
            if (personelListesi == null || personelListesi.Count == 0)
            {
                throw new ArgumentException("Personel listesi boş olamaz.", nameof(personelListesi));
            }

            // Maaşları hesaplanan ay ve yılı alır.
            string ayYil = DateTime.Now.ToString("MMMM yyyy");

            // Personel listesindeki her bir personel için döngü başlatır.
            foreach (var personel in personelListesi)
            {
                // Personelin maaşını hesaplar.
                double maas = personel.MaasHesapla();
                double mesai = personel.EkmesaiHesapla();
                string toplamOdemeString = maas.ToString();

                // Maaş bilgilerini içeren JSON verisini oluşturur.
                string dosyaAdi = $"{personel.AdSoyad}_Maas_{ayYil}.json";
                dynamic jsonData = new
                {
                    PersonelIsmi = $"{personel.AdSoyad}",
                    CalismaSaati = personel.CalismaSaati,
                    AnaOdeme = maas,
                    Mesai = personel.EkmesaiHesapla(),
                    ToplamOdeme = maas + personel.EkmesaiHesapla()
                };

                // JSON verisini dosyaya kaydeder.
                string jsonString = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                File.WriteAllText(dosyaAdi, jsonString);
            }
        }

        // AzCalisanlariRaporla metodu: Çalışma saati 150 saatten az olan personellerin raporunu ekrana yazdırır.
        public void AzCalisanlariRaporla<T>(List<T> personelListesi) where T : IPersonel
        {
            // Personel listesinin boş olup olmadığını kontrol eder.
            if (personelListesi == null || personelListesi.Count == 0)
            {
                throw new ArgumentException("Personel listesi boş olamaz.", nameof(personelListesi));
            }

            // Başlık yazdırır.
            Console.WriteLine("Az çalışanlar raporu:");

            // Personel listesindeki her bir personel için döngü başlatır.
            foreach (var personel in personelListesi)
            {
                // Çalışma saati 150 saatten az olan personellerin bilgilerini ekrana yazdırır.
                if (personel.CalismaSaati < 150)
                {
                    Console.WriteLine($"{personel.AdSoyad} - Çalışma Saati: {personel.CalismaSaati}");
                }
            }

        }
    }
}

