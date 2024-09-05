using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Abstract;
using LibraryProject.Enums;

namespace LibraryProject.Concrete
{
    // Üye sınıfı, kütüphaneye üye olan kişilerin bilgilerini ve ödünç aldıkları kitapları yönetir.
    public class Member : IMember
    {
        // Üye numarasını temsil eden özellik
        public int UyeNumarasi { get; set; }

        // Üyenin adını temsil eden özellik
        public string Ad { get; set; }

        // Üyenin soyadını temsil eden özellik
        public string Soyad { get; set; }

        // Üyenin ödünç aldığı kitapları tutan liste özelliği
        public List<Book> OduncAlinanKitaplar { get; set; }

        // Üye sınıfının yapıcı metodu. Üye numarası, adı ve soyadıyla başlatılır.
        public Member(int uyeNumarasi, string ad, string soyad)
        {
            UyeNumarasi = uyeNumarasi;
            Ad = ad;
            Soyad = soyad;
            // Ödünç alınan kitapları tutan liste başlatılır.
            OduncAlinanKitaplar = new List<Book>();
        }

        // Üyenin ödünç aldığı kitapları listesine eklemek için metot.
        public void KitapOduncAl(Book book)
        {
            // Eğer kitabın durumu ödünç alınamazsa hata fırlatılır.
            if (book.Durum != Status.OduncAlabilir)
            {
                throw new Exception("Belirtilen kitap ödünç alınamaz durumda.");
            }

            // Kitabın durumunu ödünç verildi olarak günceller ve listeye ekler.
            book.Durum = Status.OduncVerildi;
            OduncAlinanKitaplar.Add(book);
        }

        // Üyenin ödünç aldığı kitabı iade etmek için metot.
        public void KitapIadeEt(Book book)
        {
            // Eğer kitap ödünç alınmamışsa hata fırlatılır.
            if (!OduncAlinanKitaplar.Contains(book))
            {
                throw new Exception("Belirtilen kitap ödünç alınmamış.");
            }

            // Kitabın durumunu ödünç alınabilir olarak günceller ve listeden çıkarır.
            book.Durum = Status.OduncAlabilir;
            OduncAlinanKitaplar.Remove(book);
        }

        // Üyenin ödünç aldığı kitapları görüntülemek için metot.
        public List<Book> OduncAlinanKitaplariGoruntule()
        {
            return OduncAlinanKitaplar;
        }
    }
}

