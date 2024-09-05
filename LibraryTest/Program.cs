using LibraryProject.Concrete;

namespace LibraryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library kutuphane = new Library();

            // Kitapları ekle
            ScienceBook kitap1 = new ScienceBook("1234567890", "Cosmos", "Carl Sagan", 1980);
            Novels kitap2 = new Novels("0987654321", "The Lord Of The Ring", "Yazar J.R.R. Tolkien", 1954);
            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);

            // Üyeleri ekle
            Member uye1 = new Member(1, "Onur", "Anatça");
            kutuphane.UyeEkle(uye1);

            Console.WriteLine("********** KÜTÜPHANE OTOMASYON SİSTEMİ **********");
            Console.WriteLine();


            // Üyeleri görüntüle
            var tumUyeler = kutuphane.TumUyeleriGoruntule();
            Console.WriteLine("Tüm Üyeler:");
            foreach (var uye in tumUyeler)
            {
                Console.WriteLine($"Üye No: {uye.UyeNumarasi}, İsim: {uye.Ad} {uye.Soyad}");
            }
            Console.WriteLine();

            // Kitapları görüntüle
            Console.WriteLine("---- Tüm Kitaplar ----");
            var tumKitaplar = kutuphane.TumKitaplariGoruntule();
            foreach (var kitap in tumKitaplar)
            {
                Console.WriteLine($"ISBN: {kitap.ISBN}, Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}, Yayın Yılı: {kitap.YayinYili}, Durum: {kitap.Durum}");
            }
            Console.WriteLine();

            // Kitap ödünç al
            Console.WriteLine("---- Kitap Ödünç Alma ----");
            try
            {
                kutuphane.KitapOduncVer(1, "1234567890");
                Console.WriteLine("Kitap ödünç alındı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            Console.WriteLine();

            // Kitap alan üyeyi ve aldığı kitabı görüntüle
            Console.WriteLine("---- Ödünç Alınan Kitaplar ----");
            foreach (var uye in kutuphane.TumUyeleriGoruntule())
            {
                Console.WriteLine($"Üye: {uye.Ad} {uye.Soyad}");

                var aldigiKitaplar = uye.OduncAlinanKitaplariGoruntule();
                if (aldigiKitaplar.Count == 0)
                {
                    Console.WriteLine("Bu üye henüz kitap ödünç almamış.");
                }
                else
                {
                    Console.WriteLine("Aldığı Kitaplar:");
                    foreach (var kitap in aldigiKitaplar)
                    {
                        Console.WriteLine($"- {kitap.Baslik} ({kitap.Yazar})");
                    }
                }
                Console.WriteLine();
                // Kitapları görüntüle (güncel durum)
                Console.WriteLine("---- Tüm Kitaplar (Güncel Durum) ----");
                tumKitaplar = kutuphane.TumKitaplariGoruntule();
                foreach (var kitap in tumKitaplar)
                {
                    Console.WriteLine($"ISBN: {kitap.ISBN}, Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}, Yayın Yılı: {kitap.YayinYili}, Durum: {kitap.Durum}");
                }
                Console.WriteLine();

                // Kitap iade et
                Console.WriteLine("---- Kitap İade ----");
                try
                {
                    kutuphane.KitapIadeAl(1, "1234567890");
                    Console.WriteLine("Kitap iade edildi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
                Console.WriteLine();

                // Kütüphane durumunu tekrar görüntüle
                Console.WriteLine("---- Tüm Kitaplar (Güncel Durum) ----");
                tumKitaplar = kutuphane.TumKitaplariGoruntule();
                foreach (var kitap in tumKitaplar)
                {
                    Console.WriteLine($"ISBN: {kitap.ISBN}, Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}, Yayın Yılı: {kitap.YayinYili}, Durum: {kitap.Durum}");
                }

                Console.WriteLine();
                Console.WriteLine("***********************************************");
                Console.ReadLine();
            }
        }
    }
}
