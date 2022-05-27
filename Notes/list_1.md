## 6 Nisan 2022 - List'e Giris

Hey,  
Sirada **generic** yapilar var.

`List`'ler otomatik olarak buyuyebilen bir container yapisi.

Iste bir List ornegi (direk olarak ogeleri baslatilan. **Bkz. collection-initializer syntax**):

```c#
using System.Collections.Generic;

namespace ListLession
{
    class Program
    {
        static void Main(string[] args)
        {
            // direk olarak baslatmak yerine Add da kullanilabilir. Bu guzel bir sintaks.
            List<int> collections = new List<int>()
            {
                3,
                5,
                6,
                19,
                 20,
                  36,
            };
            double result = 0.0;
            foreach (var i in collections)
            {
                result += Convert.ToDouble(i);
            }
            result /= collections.Count;
            Console.WriteLine("{0} ortalama", result);

        }

    }

}

```



## Ogrenimler

- C# **generic** destekliyor. Inanilmaz mutlu oldum.
- `foreach` ile `List` uzerinde dongu yapabiliyorum.
- Scope'un en disinda tanimlanmis bir degisken baslatilmamissa hata aliyoruz. `double result = 0;` satirini `double result;` olarak degistirdiginizi dusunun.
- `var` anahtar kelimesi otomatik tur cikarimi yapiyor. Golang'in `:=` yapisina esit diyebiliriz.
