using System;
using Newtonsoft.Json;
using PayrollProject.Abstract;
using PayrollProject.Concrete;

namespace PayrollTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "personellistesi.json";

            // Personel listesini dosyadan oku
            ReadFile<IPersonel> reader = new ReadFile<IPersonel>();
            List<IPersonel> personelListesi = reader.JsonDosyadanOku(@"C:\Users\onura\source\repos\Sınav\PayrollTest\bin\Debug\net6.0\personellistesi.json");

            // Kullanıcıdan çalışma saati ve mesai bilgilerini al, ana ödemeyi otomatik hesapla
            foreach (var personel in personelListesi)
            {
                Console.Write($"Personel Adı: {personel.AdSoyad}, Konum:{personel.Title}, Çalışma Saati: ");
                personel.CalismaSaati = Convert.ToDouble(Console.ReadLine());

                // Ana ödeme hesaplanır
                decimal anaOdeme =Convert.ToDecimal(personel.MaasHesapla());

                //Ek mesai ödemesi hesaplanır
                decimal mesai = Convert.ToDecimal(personel.EkmesaiHesapla());

                // Toplam ödeme hesaplanır
                decimal toplamOdeme = anaOdeme + mesai;

                // Klasör adı
                string klasorAdi = personel.AdSoyad;
                // Klasör yoksa oluştur
                if (!Directory.Exists(klasorAdi))
                {
                    Directory.CreateDirectory(klasorAdi);
                }
                // Maaşları hesapla ve kaydet
                Payroll payroll1 = new Payroll();
                payroll1.MaaslariHesaplaVeKaydet(personelListesi);
            }

            // Az çalışanları raporla
            Payroll payroll = new Payroll();
            payroll.AzCalisanlariRaporla(personelListesi);
            Console.ReadLine();
        }
    }
}

