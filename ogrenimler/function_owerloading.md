## 5 Nisan 2022 - Overloading

Sevgili Romalılar,  
Aynı adda tanımlanan ve her tanımında farklı parametre türlerine sahip olan metod bildirimlerine `function overloading`  diyebiliriz (henüz .Net dünyası terminolojisine o kadar iyi alışamadığım için nasıl doğru ifade edilir bilmiyorum).  
C++'da alışık olduğumuz gibi (bu da artık bıkkınlık verdi), bir şeyi **overload** etmek önemli bir konu.  
Bize, bir işlemi farklı türlerle, farklı biçimlerle yapma imkanı veriyor.  
Ortamınızda `int` ve `string`ler tercih ediliyor olsun. Bir metod için **string** parametre, diğeri için **int** parametre alan bir metod yazabiliriz.  
Derleyici burada bizim için yazdığımız koddan hangi fonksiyonun çağrılacağını anlayabiliyor. Eğer int kullanmışsak, parametresi int olan fonksiyon kullanılıyor olacak.

### Önemli bir nokta: Boilerplate .NET ile overloading çalışmak zor

Yeni .NET template'i yazdığımız kodu en nihayetinde yine bir  `namespace`'e, sonrasında bir `class`'a ve en sonunda da yine bir `Main`  fonksiyonuna taşıyor.  
Bu yüzden overload yaparken derleyici doğru kodu yazamıyor.  
Eski template'i kullanmakta fayda var.

- Arkaplanda tam olarak ne olduğuna hakim değilim. Stackoverflow ve araştırmalarım böyle söylüyor. C#'da derinleştikçe bilgimiz artacaktır.

### Basit Bir Owerload Örneği

```c#
using System.Globalization;

namespace DateWorks
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static string GetLastDayOfMonth(DateTime date)
        {
            int lastDay = DateTime.DaysInMonth(date.Year, date.Month);
            date = new DateTime(date.Year, date.Month, lastDay);
            return date.ToString("dddd");
        }

        static string GetLastDayOfMonth(DateTime date, CultureInfo cultureInfo)
        {
            int lastDay = DateTime.DaysInMonth(date.Year, date.Month);
            date = new DateTime(date.Year, date.Month, lastDay);
            return date.ToString("dddd", cultureInfo);
        }

    }

}

```

