using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Abstract;

namespace LibraryProject.Concrete
{
    // Tarih kitabı sınıfı, temel kitap sınıfından miras alınarak oluşturulmuştur.
    public class HistoryBook : Book
    {// Tarih kitabı sınıfının yapıcı metodu.
     // Parametreler:
     //   isbn: Kitabın ISBN numarası
     //   baslik: Kitabın başlığı
     //   yazar: Kitabın yazarı
     //   yayinYili: Kitabın yayın yılı
     // HistoryBook sınıfının yapıcı metodu. Gelen parametreleri kontrol eder ve uygun hata mesajlarını fırlatır.
        public HistoryBook(string isbn, string baslik, string yazar, int yayinYili)
            : base(isbn, baslik, yazar, yayinYili) // Base sınıfın yapıcı metodunu çağırır.
        {
            
        }
    }
}
