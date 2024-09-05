using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Abstract;

namespace LibraryProject.Concrete
{
    // Bilim kitabı sınıfı, temel kitap sınıfından miras alınarak oluşturulmuştur.
    public class ScienceBook : Book
    {// Bilim kitabı sınıfının yapıcı metodu.
     // Parametreler:
     //   isbn: Kitabın ISBN numarası
     //   baslik: Kitabın başlığı
     //   yazar: Kitabın yazarı
     //   yayinYili: Kitabın yayın yılı
        public ScienceBook(string isbn, string baslik, string yazar, int yayinYili)
            : base(isbn, baslik, yazar, yayinYili)
        {
        }
    }
}
