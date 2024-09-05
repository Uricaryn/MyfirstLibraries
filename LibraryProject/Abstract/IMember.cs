using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Abstract
{
    public interface IMember
    {
        // Üyenin numarasını temsil eden özellik
        int UyeNumarasi { get; set; }

        // Üyenin adını temsil eden özellik
        string Ad { get; set; }

        // Üyenin soyadını temsil eden özellik
        string Soyad { get; set; }

        // Üyenin ödünç aldığı kitapları temsil eden liste özelliği
        List<Book> OduncAlinanKitaplar { get; set; }

        // Belirtilen kitabı üye tarafından ödünç almak için metot
        void KitapOduncAl(Book book);

        // Belirtilen kitabı üye tarafından iade etmek için metot
        void KitapIadeEt(Book book);

        // Üyenin ödünç aldığı tüm kitapları görüntülemek için metot
        List<Book> OduncAlinanKitaplariGoruntule();
    }
}
