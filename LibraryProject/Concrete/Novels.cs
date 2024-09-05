using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Abstract;

namespace LibraryProject.Concrete
{
    // Roman kitabı sınıfı, temel kitap sınıfından miras alınarak oluşturulmuştur.
    public class Novels : Book
    {// Roman kitabı sınıfının yapıcı metodu.
     // Parametreler:
     //   isbn: Kitabın ISBN numarası
     //   baslik: Kitabın başlığı
     //   yazar: Kitabın yazarı
     //   yayinYili: Kitabın yayın yılı
        public Novels(string isbn, string baslik, string yazar, int yayinYili)
            : base(isbn, baslik, yazar, yayinYili)
        {
           
        }
    }
}

