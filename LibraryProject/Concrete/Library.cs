using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Abstract;
using LibraryProject.Enums;

namespace LibraryProject.Concrete
{
    // Kütüphane sınıfı, kitapları ve üyeleri yönetir.
    public class Library
    {
        // Kütüphanedeki tüm kitapları temsil eden liste özelliği
        public List<Book> Kitaplar { get; set; }

        // Kütüphanedeki tüm üyeleri temsil eden liste özelliği
        public List<Member> Uyeler { get; set; }

        // Kütüphane sınıfının yapıcı metodu.
        public Library()
        {
            // Kitaplar ve üyeler listelerini başlatır.
            Kitaplar = new List<Book>();
            Uyeler = new List<Member>();
        }

        // Kütüphaneye yeni bir kitap eklemek için metot.
        public void KitapEkle(Book kitap)
        {
            // Aynı ISBN numarasına sahip bir kitap zaten varsa eklemeyi engelle
            foreach (var existingKitap in Kitaplar)
            {
                if (existingKitap.ISBN == kitap.ISBN)
                {
                    throw new Exception("Aynı ISBN numarasına sahip bir kitap zaten mevcut.");
                }
            }

            Kitaplar.Add(kitap);
        }

        // Kütüphaneye yeni bir üye eklemek için metot.
        public void UyeEkle(Member uye)
        {
            // Aynı üye numarasına sahip bir üye zaten varsa eklemeyi engelle
            foreach (var existingUye in Uyeler)
            {
                if (existingUye.UyeNumarasi == uye.UyeNumarasi)
                {
                    throw new Exception("Aynı üye numarasına sahip bir üye zaten mevcut.");
                }
            }

            Uyeler.Add(uye);
        }

        // Bir üyeye kitap ödünç vermek için metot.
        public void KitapOduncVer(int uyeNumarasi, string isbn)
        {
            // Belirtilen üye ve kitabı bulmak için döngüler kullanılır.
            Member uye = null;
            foreach (var u in Uyeler)
            {
                if (u.UyeNumarasi == uyeNumarasi)
                {
                    uye = u;
                    break;
                }
            }

            Book kitap = null;
            foreach (var k in Kitaplar)
            {
                if (k.ISBN == isbn)
                {
                    kitap = k;
                    break;
                }
            }

            // Eğer üye veya kitap bulunamazsa hata fırlatır.
            if (uye == null)
            {
                throw new Exception("Belirtilen üye bulunamadı.");
            }

            if (kitap == null)
            {
                throw new Exception("Belirtilen kitap bulunamadı.");
            }

            // Eğer kitabın durumu ödünç alınabilir değilse hata fırlatır.
            if (kitap.Durum != Status.OduncAlabilir)
            {
                throw new Exception("Belirtilen kitap ödünç alınamaz durumda.");
            }

            // Kitabı ödünç alan üyenin listesine ekler ve durumunu günceller.
            uye.KitapOduncAl(kitap);
            kitap.Durum = Status.OduncVerildi;
        }

        // Bir üyeden kitabı iade almak için metot.
        public void KitapIadeAl(int uyeNumarasi, string isbn)
        {
            // Belirtilen üye ve kitabı bulmak için döngüler kullanılır.
            Member uye = null;
            foreach (var u in Uyeler)
            {
                if (u.UyeNumarasi == uyeNumarasi)
                {
                    uye = u;
                    break;
                }
            }

            Book kitap = null;
            foreach (var k in Kitaplar)
            {
                if (k.ISBN == isbn)
                {
                    kitap = k;
                    break;
                }
            }

            // Eğer üye veya kitap bulunamazsa hata fırlatır.
            if (uye == null)
            {
                throw new Exception("Belirtilen üye bulunamadı.");
            }

            if (kitap == null)
            {
                throw new Exception("Belirtilen kitap bulunamadı.");
            }

            // Eğer kitabın durumu ödünç verildi değilse hata fırlatır.
            if (kitap.Durum != Status.OduncVerildi)
            {
                throw new Exception("Belirtilen kitap iade edilemez durumda.");
            }

            // Kitabı iade eden üyenin listesinden çıkarır ve durumunu günceller.
            uye.KitapIadeEt(kitap);
            kitap.Durum = Status.OduncAlabilir;
        }

        // Kütüphanedeki tüm kitapları görüntülemek için metot.
        public List<Book> TumKitaplariGoruntule()
        {
            return Kitaplar;
        }

        // Kütüphanedeki tüm üyeleri görüntülemek için metot.
        public List<Member> TumUyeleriGoruntule()
        {
            return Uyeler;
        }

        // Ödünç verilen tüm kitapları görüntülemek için metot.
        public List<Book> OduncVerilenKitaplariGoruntule()
        {
            List<Book> oduncVerilenKitaplar = new List<Book>();

            foreach (var kitap in Kitaplar)
            {
                if (kitap.Durum == Status.OduncVerildi)
                {
                    oduncVerilenKitaplar.Add(kitap);
                }
            }

            return oduncVerilenKitaplar;
        }

        public Book KitapBul(string isbn)
        {
            foreach (var kitap in Kitaplar)
            {
                if (kitap.ISBN == isbn)
                {
                    return kitap;
                }
            }
            return null;
        }
    }
}