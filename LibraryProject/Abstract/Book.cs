using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Enums;

namespace LibraryProject.Abstract
{
    public abstract class Book
    {// Kitabın ISBN numarasını temsil eden özellik
        public string ISBN { get; set; }

        // Kitabın başlığını temsil eden özellik
        public string Baslik { get; set; }

        // Kitabın yazarını temsil eden özellik
        public string Yazar { get; set; }

        // Kitabın yayın yılını temsil eden özellik
        public int YayinYili { get; set; }

        // Kitabın durumunu temsil eden özellik
        public Status Durum { get; set; }

        // Kitabın yapıcı metodu, ISBN, başlık, yazar ve yayın yılı parametreleri alır
        protected Book(string isbn, string baslik, string yazar, int yayinYili)
        {
            // Parametrelerle kitabın özelliklerini başlatır
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            // Kitabın durumunu varsayılan olarak "Ödünç Alabilir" olarak ayarlar
            Durum = Status.OduncAlabilir;
            // ISBN parametresinin null veya boş olup olmadığını kontrol eder.
            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentNullException(nameof(isbn), "ISBN Boş olamaz.");
            }
            // Başlık parametresinin null veya boş olup olmadığını kontrol eder.
            if (string.IsNullOrEmpty(baslik))
            {
                throw new ArgumentNullException(nameof(baslik), "Başlık Boş olamaz");
            }

            // Yazar parametresinin null veya boş olup olmadığını kontrol eder.
            if (string.IsNullOrEmpty(yazar))
            {
                throw new ArgumentNullException(nameof(yazar), "Yazar Bölümü Boş Olamaz");
            }

            // Yayın yılı parametresinin sıfırdan büyük olup olmadığını kontrol eder.
            if (yayinYili <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(yayinYili), "Yayın yılı 0'dan yüksek bir değer olmalıdır");
            }
        }
    }
}
