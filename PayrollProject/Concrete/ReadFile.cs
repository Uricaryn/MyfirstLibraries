using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PayrollProject.Abstract;

namespace PayrollProject.Concrete
{
    public class ReadFile<T> where T : IPersonel

    {
        // JSON formatındaki verileri bir dosyaya yazmak için kullanılır.
        public void JsonDosyayaYaz(List<T> personelListesi, string dosyaYolu)
        {
            // Personel listesini JSON formatına dönüştürür.
            string json = JsonConvert.SerializeObject(personelListesi, Formatting.Indented);

            // Belirtilen dosya yoluna JSON verisini yazar.
            File.WriteAllText(dosyaYolu, json);
        }

        // JSON formatındaki verileri bir dosyadan okumak için kullanılır.
        public List<T> JsonDosyadanOku(string dosyaYolu)
        {
            // Dosya yoluna sahip bir dosya mevcut değilse bir hata fırlatır.
            if (!File.Exists(dosyaYolu))
            {
                throw new FileNotFoundException("Dosya bulunamadı.", dosyaYolu);
            }

            // Dosyadaki JSON verisini okur.
            string json = File.ReadAllText(dosyaYolu);

            // JSON verisini dinamik bir nesneye dönüştürür.
            var array = JsonConvert.DeserializeObject<List<dynamic>>(json);

            // Geri dönecek olan personel listesi.
            List<T> personelListesi = new List<T>();

            // JSON verisindeki her bir öğe için döngü.
            foreach (var item in array)
            {
                // Öğenin "title" (başlık) özelliğini alır.
                string title = item.title;
                // Öğenin "name" (ad) özelliğini alır.
                string name = item.name;

                // Başlığa göre farklı tipte personel nesneleri oluşturulur ve listeye eklenir.
                switch (title)
                {
                    case "Yonetici":
                        // Yönetici tipinde bir nesne oluşturulur ve listeye eklenir.
                        personelListesi.Add((T)(IPersonel)new Yonetici { AdSoyad = name, Title = title });
                        break;
                    case "Memur":
                        // Memur tipinde bir nesne oluşturulur ve listeye eklenir.
                        personelListesi.Add((T)(IPersonel)new Memur(500) { AdSoyad = name, Title = title });
                        break;
                }
            }

            // Oluşturulan personel listesi geri döndürülür.
            return personelListesi;
        }
    }
}
